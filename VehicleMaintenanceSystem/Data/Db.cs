using System.Data;
using Npgsql;

namespace VehicleMaintenanceSystem.Data;

public static class Db
{
    // PostgreSQL settings
    private const string Host = "localhost";
    private const string Port = "5432";
    private const string User = "postgres";
    private const string Password = "nicekevin";
    public const string DatabaseName = "vehicle_db";

    public static string ConnectionString => Build(DatabaseName);
    public static string ServerConnectionString => Build("postgres");

    private static string Build(string database) =>
        $"Host={Host};Port={Port};Username={User};Password={Password};Database={database}";

    public static NpgsqlParameter P(string name, object value) =>
        new NpgsqlParameter(name, value ?? DBNull.Value);

    public static NpgsqlParameter PDate(string name, DateTime value) =>
        new NpgsqlParameter(name, DateOnly.FromDateTime(value));

    public static DataTable Query(string sql, params NpgsqlParameter[] parameters)
    {
        using var conn = new NpgsqlConnection(ConnectionString);
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddRange(parameters);
        using var adapter = new NpgsqlDataAdapter(cmd);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }

    public static int Execute(string sql, params NpgsqlParameter[] parameters)
    {
        using var conn = new NpgsqlConnection(ConnectionString);
        conn.Open();
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddRange(parameters);
        return cmd.ExecuteNonQuery();
    }

    public static object Scalar(string sql, params NpgsqlParameter[] parameters)
    {
        using var conn = new NpgsqlConnection(ConnectionString);
        conn.Open();
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddRange(parameters);
        return cmd.ExecuteScalar();
    }
}
