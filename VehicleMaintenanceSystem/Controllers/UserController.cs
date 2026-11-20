using System.Data;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class UserController : ControllerBase
{
    private readonly UserRepository _repo = new();

    public DataTable GetUsers() => Session.CanManageUsers ? _repo.GetAll() : new DataTable();

    public User Get(int id) => Session.CanManageUsers ? _repo.GetById(id) : null;

    public OperationResult Save(User u, string password)
    {
        if (!Session.CanManageUsers) return Deny();

        u.FullName = (u.FullName ?? "").Trim();
        u.Username = (u.Username ?? "").Trim();
        u.Email = (u.Email ?? "").Trim();
        bool isNew = u.UserId == 0;

        if (u.FullName.Length == 0) return OperationResult.Fail("Full name is required.");
        if (u.Username.Length < 3) return OperationResult.Fail("Username is required (at least 3 characters).");
        if (u.Username.Contains(' ')) return OperationResult.Fail("Username cannot contain spaces.");
        if (!IsValidEmail(u.Email)) return OperationResult.Fail("Enter a valid email address.");
        if (Array.IndexOf(Roles.All, u.Role) < 0) return OperationResult.Fail("Select a role.");
        if (isNew && string.IsNullOrEmpty(password)) return OperationResult.Fail("Password is required for a new user.");
        if (!string.IsNullOrEmpty(password) && password.Length < 6)
            return OperationResult.Fail("Password must be at least 6 characters.");

        return Try(() =>
        {
            if (_repo.UsernameExists(u.Username, u.UserId)) return OperationResult.Fail("This username is already used.");
            if (_repo.EmailExists(u.Email, u.UserId)) return OperationResult.Fail("This email is already used.");

            if (isNew)
            {
                u.PasswordHash = PasswordHasher.Hash(password);
                u.IsActive = true;
                int id = _repo.Insert(u);
                return OperationResult.Ok("User created.", id);
            }

            var existing = _repo.GetById(u.UserId);
            if (existing == null) return OperationResult.Fail("User not found.");

            if (existing.Role == Roles.Administrator && u.Role != Roles.Administrator &&
                existing.IsActive && _repo.CountActiveAdmins() <= 1)
                return OperationResult.Fail("At least one active administrator must remain.");

            bool changePwd = !string.IsNullOrEmpty(password);
            if (changePwd) u.PasswordHash = PasswordHasher.Hash(password);
            _repo.Update(u, changePwd);

            if (Session.CurrentUser.UserId == u.UserId)
                Session.CurrentUser = _repo.GetById(u.UserId);

            return OperationResult.Ok("User updated.", u.UserId);
        });
    }

    public OperationResult SetActive(int userId, bool active)
    {
        if (!Session.CanManageUsers) return Deny();
        if (!active && Session.CurrentUser.UserId == userId)
            return OperationResult.Fail("You cannot deactivate your own account.");

        return Try(() =>
        {
            var user = _repo.GetById(userId);
            if (user == null) return OperationResult.Fail("User not found.");
            if (!active && user.Role == Roles.Administrator && user.IsActive && _repo.CountActiveAdmins() <= 1)
                return OperationResult.Fail("At least one active administrator must remain.");

            _repo.SetActive(userId, active);
            return OperationResult.Ok(active ? "User activated." : "User deactivated.", userId);
        });
    }
}
