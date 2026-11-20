using System.Data;
using Npgsql;
using VehicleMaintenanceSystem.Models;
using static VehicleMaintenanceSystem.Data.Db;

namespace VehicleMaintenanceSystem.Data;

public class DriverRepository
{
    private static Driver Map(DataRow r) => new Driver
    {
        DriverId = Convert.ToInt32(r["driver_id"]),
        FullName = r["full_name"].ToString(),
        Phone = r["phone"].ToString(),
        Email = r["email"] is DBNull ? "" : r["email"].ToString(),
        LicenceNumber = r["licence_number"].ToString(),
        LicenceCategory = r["licence_category"].ToString(),
        LicenceExpiry = Convert.ToDateTime(r["licence_expiry"])
    };

    public DataTable Search(string term)
    {
        string sql = @"
            SELECT d.driver_id,
                   d.full_name AS ""Name"",
                   d.phone AS ""Phone"",
                   COALESCE(d.email, '') AS ""Email"",
                   d.licence_number AS ""Licence No"",
                   d.licence_category AS ""Category"",
                   d.licence_expiry AS ""Licence Expiry"",
                   COALESCE((SELECT string_agg(v.registration_number, ', ')
                             FROM vehicles v WHERE v.driver_id = d.driver_id), 'None') AS ""Assigned Vehicle(s)""
            FROM drivers d";
        var ps = new List<NpgsqlParameter>();
        if (!string.IsNullOrWhiteSpace(term))
        {
            sql += " WHERE d.full_name ILIKE @t OR d.licence_number ILIKE @t";
            ps.Add(P("t", "%" + term.Trim() + "%"));
        }
        sql += " ORDER BY d.full_name";
        return Query(sql, ps.ToArray());
    }

    public Driver GetById(int id)
    {
        var dt = Query("SELECT * FROM drivers WHERE driver_id=@id", P("id", id));
        return dt.Rows.Count == 0 ? null : Map(dt.Rows[0]);
    }

    public bool LicenceExists(string licence, int excludeId) =>
        Convert.ToInt64(Scalar("SELECT COUNT(*) FROM drivers WHERE UPPER(licence_number)=UPPER(@l) AND driver_id<>@id",
            P("l", licence), P("id", excludeId))) > 0;

    public int Insert(Driver d) => Convert.ToInt32(Scalar(@"
        INSERT INTO drivers (full_name, phone, email, licence_number, licence_category, licence_expiry)
        VALUES (@n, @p, @e, @l, @c, @x) RETURNING driver_id",
        P("n", d.FullName), P("p", d.Phone), P("e", string.IsNullOrWhiteSpace(d.Email) ? null : d.Email),
        P("l", d.LicenceNumber), P("c", d.LicenceCategory), PDate("x", d.LicenceExpiry)));

    public void Update(Driver d) => Execute(@"
        UPDATE drivers SET full_name=@n, phone=@p, email=@e, licence_number=@l,
                           licence_category=@c, licence_expiry=@x
        WHERE driver_id=@id",
        P("n", d.FullName), P("p", d.Phone), P("e", string.IsNullOrWhiteSpace(d.Email) ? null : d.Email),
        P("l", d.LicenceNumber), P("c", d.LicenceCategory), PDate("x", d.LicenceExpiry), P("id", d.DriverId));
}
