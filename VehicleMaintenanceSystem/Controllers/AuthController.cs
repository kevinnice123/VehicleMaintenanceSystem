using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class AuthController : ControllerBase
{
    private readonly UserRepository _users = new();

    public OperationResult Login(string login, string password)
    {
        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password))
            return OperationResult.Fail("Enter both your username/email and password.");

        return Try(() =>
        {
            var user = _users.GetByLogin(login.Trim());
            if (user == null || !PasswordHasher.Verify(password, user.PasswordHash))
                return OperationResult.Fail("Invalid username/email or password.");
            if (!user.IsActive)
                return OperationResult.Fail("This account is deactivated. Contact the administrator.");

            Session.CurrentUser = user;
            return OperationResult.Ok("Login successful.", user.UserId);
        });
    }

    // New accounts get the lowest role. The administrator can change it later in User Accounts.
    public OperationResult Register(string fullName, string username, string email, string password, string confirm)
    {
        fullName = (fullName ?? "").Trim();
        username = (username ?? "").Trim();
        email = (email ?? "").Trim();

        if (fullName.Length == 0) return OperationResult.Fail("Full name is required.");
        if (username.Length < 3) return OperationResult.Fail("Username is required (at least 3 characters).");
        if (username.Contains(' ')) return OperationResult.Fail("Username cannot contain spaces.");
        if (!IsValidEmail(email)) return OperationResult.Fail("Enter a valid email address.");
        if (string.IsNullOrEmpty(password) || password.Length < 6)
            return OperationResult.Fail("Password must be at least 6 characters.");
        if (password != confirm) return OperationResult.Fail("The two passwords do not match.");

        return Try(() =>
        {
            if (_users.UsernameExists(username, 0)) return OperationResult.Fail("This username is already used.");
            if (_users.EmailExists(email, 0)) return OperationResult.Fail("This email is already used.");

            var user = new User
            {
                FullName = fullName,
                Username = username,
                Email = email,
                PasswordHash = PasswordHasher.Hash(password),
                Role = Roles.Management,
                IsActive = true
            };
            int id = _users.Insert(user);
            return OperationResult.Ok("Account created. You can log in now. The administrator can change your role.", id);
        });
    }

    public void Logout() => Session.CurrentUser = null;
}
