using System.Data;
using VehicleMaintenanceSystem.Models;
using static VehicleMaintenanceSystem.Data.Db;

namespace VehicleMaintenanceSystem.Data;

public class UserRepository
{
    private static User Map(DataRow r) => new User
    {
        UserId = Convert.ToInt32(r["user_id"]),
        FullName = r["full_name"].ToString(),
        Username = r["username"].ToString(),
        Email = r["email"].ToString(),
        PasswordHash = r["password_hash"].ToString(),
        Role = r["role"].ToString(),
        IsActive = Convert.ToBoolean(r["is_active"])
    };

    public DataTable GetAll() => Query(@"
        SELECT user_id,
               full_name AS ""Full Name"",
               username  AS ""Username"",
               email     AS ""Email"",
               role      AS ""Role"",
               CASE WHEN is_active THEN 'Active' ELSE 'Inactive' END AS ""Status""
        FROM users ORDER BY full_name");

    public User GetById(int id)
    {
        var dt = Query("SELECT * FROM users WHERE user_id = @id", P("id", id));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public User GetByLogin(string login)
    {
        var dt = Query(@"SELECT * FROM users
                         WHERE LOWER(username) = LOWER(@l) OR LOWER(email) = LOWER(@l)", P("l", login));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public bool UsernameExists(string username, int excludeId) =>
        Convert.ToInt64(Scalar("SELECT COUNT(*) FROM users WHERE LOWER(username)=LOWER(@u) AND user_id<>@id",
            P("u", username), P("id", excludeId))) > 0;

    public bool EmailExists(string email, int excludeId) =>
        Convert.ToInt64(Scalar("SELECT COUNT(*) FROM users WHERE LOWER(email)=LOWER(@e) AND user_id<>@id",
            P("e", email), P("id", excludeId))) > 0;

    public int CountActiveAdmins() =>
        Convert.ToInt32(Scalar("SELECT COUNT(*) FROM users WHERE role = @r AND is_active", P("r", Roles.Administrator)));

    public int Insert(User u) => Convert.ToInt32(Scalar(@"
        INSERT INTO users (full_name, username, email, password_hash, role, is_active)
        VALUES (@n, @u, @e, @p, @r, @a) RETURNING user_id",
        P("n", u.FullName), P("u", u.Username), P("e", u.Email),
        P("p", u.PasswordHash), P("r", u.Role), P("a", u.IsActive)));

    public void Update(User u, bool changePassword)
    {
        if (changePassword)
            Execute(@"UPDATE users SET full_name=@n, username=@u, email=@e, role=@r, password_hash=@p WHERE user_id=@id",
                P("n", u.FullName), P("u", u.Username), P("e", u.Email), P("r", u.Role),
                P("p", u.PasswordHash), P("id", u.UserId));
        else
            Execute(@"UPDATE users SET full_name=@n, username=@u, email=@e, role=@r WHERE user_id=@id",
                P("n", u.FullName), P("u", u.Username), P("e", u.Email), P("r", u.Role), P("id", u.UserId));
    }

    public void SetActive(int id, bool active) =>
        Execute("UPDATE users SET is_active=@a WHERE user_id=@id", P("a", active), P("id", id));
}
