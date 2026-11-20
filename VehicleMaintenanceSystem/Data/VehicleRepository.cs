using System.Data;
using Npgsql;
using VehicleMaintenanceSystem.Models;
using static VehicleMaintenanceSystem.Data.Db;

namespace VehicleMaintenanceSystem.Data;

public class VehicleRepository
{
    private static Vehicle Map(DataRow r) => new Vehicle
    {
        VehicleId = Convert.ToInt32(r["vehicle_id"]),
        RegistrationNumber = r["registration_number"].ToString(),
        Make = r["make"].ToString(),
        Model = r["model"].ToString(),
        Year = Convert.ToInt32(r["manufacture_year"]),
        VehicleType = r["vehicle_type"].ToString(),
        Mileage = Convert.ToInt32(r["mileage"]),
        DriverId = r["driver_id"] is DBNull ? null : Convert.ToInt32(r["driver_id"])
    };

    public DataTable Search(string term)
    {
        string sql = @"
            SELECT v.vehicle_id,
                   v.registration_number AS ""Reg. No"",
                   v.make AS ""Make"",
                   v.model AS ""Model"",
                   v.manufacture_year AS ""Year"",
                   v.vehicle_type AS ""Type"",
                   v.mileage AS ""Mileage (km)"",
                   COALESCE(d.full_name, 'Unassigned') AS ""Driver""
            FROM vehicles v
            LEFT JOIN drivers d ON d.driver_id = v.driver_id";
        var ps = new List<NpgsqlParameter>();
        if (!string.IsNullOrWhiteSpace(term))
        {
            sql += " WHERE v.registration_number ILIKE @t OR v.model ILIKE @t";
            ps.Add(P("t", "%" + term.Trim() + "%"));
        }
        sql += " ORDER BY v.registration_number";
        return Query(sql, ps.ToArray());
    }

    public DataTable GetLookup()
    {
        var dt = Query(@"SELECT vehicle_id, registration_number || ' - ' || make || ' ' || model AS display
                         FROM vehicles ORDER BY registration_number");
        return dt;
    }

    public Vehicle GetById(int id)
    {
        var dt = Query("SELECT * FROM vehicles WHERE vehicle_id=@id", P("id", id));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public bool RegistrationExists(string reg, int excludeId) =>
        Convert.ToInt64(Scalar("SELECT COUNT(*) FROM vehicles WHERE UPPER(registration_number)=UPPER(@r) AND vehicle_id<>@id",
            P("r", reg), P("id", excludeId))) > 0;

    public int Insert(Vehicle v) => Convert.ToInt32(Scalar(@"
        INSERT INTO vehicles (registration_number, make, model, manufacture_year, vehicle_type, mileage)
        VALUES (@r, @mk, @md, @y, @t, @m) RETURNING vehicle_id",
        P("r", v.RegistrationNumber), P("mk", v.Make), P("md", v.Model),
        P("y", v.Year), P("t", v.VehicleType), P("m", v.Mileage)));

    public void Update(Vehicle v) => Execute(@"
        UPDATE vehicles SET registration_number=@r, make=@mk, model=@md, manufacture_year=@y,
                            vehicle_type=@t, mileage=@m
        WHERE vehicle_id=@id",
        P("r", v.RegistrationNumber), P("mk", v.Make), P("md", v.Model), P("y", v.Year),
        P("t", v.VehicleType), P("m", v.Mileage), P("id", v.VehicleId));

    public void SetDriver(int vehicleId, int? driverId)
    {
        if (driverId.HasValue)
            Execute("UPDATE vehicles SET driver_id=@d WHERE vehicle_id=@v", P("d", driverId.Value), P("v", vehicleId));
        else
            Execute("UPDATE vehicles SET driver_id=NULL WHERE vehicle_id=@v", P("v", vehicleId));
    }
}
