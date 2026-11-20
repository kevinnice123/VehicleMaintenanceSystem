using System.Reflection;
using Npgsql;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Data;

public static class DbInitializer
{
    public static void Initialize()
    {
        CreateDatabaseIfMissing();
        CreateTables();
        SeedUsers();
    }

    private static void CreateDatabaseIfMissing()
    {
        using var conn = new NpgsqlConnection(Db.ServerConnectionString);
        conn.Open();
        using var check = new NpgsqlCommand("SELECT 1 FROM pg_database WHERE datname = @n", conn);
        check.Parameters.AddWithValue("n", Db.DatabaseName);
        if (check.ExecuteScalar() == null)
        {
            using var create = new NpgsqlCommand($"CREATE DATABASE {Db.DatabaseName}", conn);
            create.ExecuteNonQuery();
        }
    }

    private static void CreateTables()
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("schema.sql")
            ?? throw new InvalidOperationException("schema.sql resource not found.");
        using var reader = new StreamReader(stream);
        string sql = reader.ReadToEnd();
        Db.Execute(sql);
    }

    private static void SeedUsers()
    {
        long count = Convert.ToInt64(Db.Scalar("SELECT COUNT(*) FROM users"));
        if (count > 0) return;

        var repo = new UserRepository();
        void Add(string name, string username, string email, string password, string role) =>
            repo.Insert(new User
            {
                FullName = name, Username = username, Email = email,
                PasswordHash = PasswordHasher.Hash(password), Role = role, IsActive = true
            });

        Add("System Administrator", "admin", "admin@fleet.rw", "admin123", Roles.Administrator);
        Add("Fleet Manager", "fleet", "fleet@fleet.rw", "fleet123", Roles.FleetManager);
        Add("Maintenance Officer", "officer", "officer@fleet.rw", "officer123", Roles.MaintenanceOfficer);
        Add("Management User", "manager", "manager@fleet.rw", "manager123", Roles.Management);
    }
}
