using System.Data;
using Npgsql;
using VehicleMaintenanceSystem.Models;
using static VehicleMaintenanceSystem.Data.Db;

namespace VehicleMaintenanceSystem.Data;

public class MaintenanceRepository
{
    public const string AlertSql = @"
        (CASE
            WHEN s.status IN ('Completed','Cancelled') THEN '-'
            WHEN s.planned_date < CURRENT_DATE OR v.mileage >= s.expected_mileage THEN 'Overdue'
            WHEN s.planned_date <= CURRENT_DATE + 14 OR v.mileage >= s.expected_mileage - 500 THEN 'Upcoming'
            ELSE 'Scheduled'
         END)";

    public int InsertSchedule(MaintenanceSchedule s) => Convert.ToInt32(Scalar(@"
        INSERT INTO maintenance_schedules (vehicle_id, planned_date, expected_mileage, description, status)
        VALUES (@v, @d, @m, @desc, @st) RETURNING schedule_id",
        P("v", s.VehicleId), PDate("d", s.PlannedDate), P("m", s.ExpectedMileage),
        P("desc", s.Description), P("st", s.Status)));

    public void UpdateStatus(int scheduleId, string status) =>
        Execute("UPDATE maintenance_schedules SET status=@s WHERE schedule_id=@id", P("s", status), P("id", scheduleId));

    public DataTable GetSchedules(int vehicleId, string status)
    {
        string sql = $@"
            SELECT s.schedule_id, s.vehicle_id,
                   v.registration_number AS ""Vehicle"",
                   s.planned_date AS ""Planned Date"",
                   s.expected_mileage AS ""Expected Mileage"",
                   v.mileage AS ""Current Mileage"",
                   s.description AS ""Description"",
                   s.status AS ""Status"",
                   {AlertSql} AS ""Alert""
            FROM maintenance_schedules s
            JOIN vehicles v ON v.vehicle_id = s.vehicle_id
            WHERE 1=1";
        var ps = new List<NpgsqlParameter>();
        if (vehicleId > 0) { sql += " AND s.vehicle_id=@v"; ps.Add(P("v", vehicleId)); }
        if (!string.IsNullOrEmpty(status)) { sql += " AND s.status=@st"; ps.Add(P("st", status)); }
        sql += " ORDER BY s.planned_date, s.schedule_id";
        return Query(sql, ps.ToArray());
    }

    public DataTable GetDueAlerts(int vehicleId, DateTime? from, DateTime? to)
    {
        string sql = $@"
            SELECT v.registration_number AS ""Vehicle"",
                   s.planned_date AS ""Planned Date"",
                   s.expected_mileage AS ""Expected Mileage"",
                   v.mileage AS ""Current Mileage"",
                   s.description AS ""Description"",
                   s.status AS ""Status"",
                   {AlertSql} AS ""Alert""
            FROM maintenance_schedules s
            JOIN vehicles v ON v.vehicle_id = s.vehicle_id
            WHERE {AlertSql} IN ('Overdue','Upcoming')";
        var ps = new List<NpgsqlParameter>();
        if (vehicleId > 0) { sql += " AND s.vehicle_id=@v"; ps.Add(P("v", vehicleId)); }
        if (from.HasValue) { sql += " AND s.planned_date >= @f"; ps.Add(PDate("f", from.Value)); }
        if (to.HasValue) { sql += " AND s.planned_date <= @t"; ps.Add(PDate("t", to.Value)); }
        sql += @" ORDER BY CASE WHEN " + AlertSql + @" = 'Overdue' THEN 0 ELSE 1 END, s.planned_date";
        return Query(sql, ps.ToArray());
    }

    public int InsertRecord(ServiceRecord r, int userId)
    {
        using var conn = new NpgsqlConnection(ConnectionString);
        conn.Open();
        using var tx = conn.BeginTransaction();

        int id;
        using (var cmd = new NpgsqlCommand(@"
            INSERT INTO service_records (vehicle_id, schedule_id, service_date, mileage, maintenance_type,
                                         description, service_provider, cost, created_by)
            VALUES (@v, @s, @d, @m, @t, @desc, @p, @c, @u) RETURNING record_id", conn, tx))
        {
            cmd.Parameters.Add(P("v", r.VehicleId));
            cmd.Parameters.Add(P("s", (object)r.ScheduleId));
            cmd.Parameters.Add(PDate("d", r.ServiceDate));
            cmd.Parameters.Add(P("m", r.Mileage));
            cmd.Parameters.Add(P("t", r.MaintenanceType));
            cmd.Parameters.Add(P("desc", r.Description));
            cmd.Parameters.Add(P("p", r.ServiceProvider));
            cmd.Parameters.Add(P("c", r.Cost));
            cmd.Parameters.Add(P("u", userId));
            id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        using (var cmd = new NpgsqlCommand(
            "UPDATE vehicles SET mileage = GREATEST(mileage, @m) WHERE vehicle_id=@v", conn, tx))
        {
            cmd.Parameters.Add(P("m", r.Mileage));
            cmd.Parameters.Add(P("v", r.VehicleId));
            cmd.ExecuteNonQuery();
        }

        if (r.ScheduleId.HasValue)
        {
            using var cmd = new NpgsqlCommand(
                "UPDATE maintenance_schedules SET status='Completed' WHERE schedule_id=@s", conn, tx);
            cmd.Parameters.Add(P("s", r.ScheduleId.Value));
            cmd.ExecuteNonQuery();
        }

        tx.Commit();
        return id;
    }

    public DataTable GetHistory(int vehicleId, DateTime? from, DateTime? to)
    {
        string sql = @"
            SELECT r.service_date AS ""Service Date"",
                   v.registration_number AS ""Vehicle"",
                   r.maintenance_type AS ""Type"",
                   r.description AS ""Work Description"",
                   r.service_provider AS ""Provider"",
                   r.mileage AS ""Mileage (km)"",
                   r.cost AS ""Cost (RWF)""
            FROM service_records r
            JOIN vehicles v ON v.vehicle_id = r.vehicle_id
            WHERE 1=1";
        var ps = new List<NpgsqlParameter>();
        if (vehicleId > 0) { sql += " AND r.vehicle_id=@v"; ps.Add(P("v", vehicleId)); }
        if (from.HasValue) { sql += " AND r.service_date >= @f"; ps.Add(PDate("f", from.Value)); }
        if (to.HasValue) { sql += " AND r.service_date <= @t"; ps.Add(PDate("t", to.Value)); }
        sql += " ORDER BY r.service_date DESC, r.record_id DESC";
        return Query(sql, ps.ToArray());
    }

    public decimal GetTotalCost(int vehicleId, DateTime? from, DateTime? to)
    {
        string sql = "SELECT COALESCE(SUM(cost),0) FROM service_records WHERE 1=1";
        var ps = new List<NpgsqlParameter>();
        if (vehicleId > 0) { sql += " AND vehicle_id=@v"; ps.Add(P("v", vehicleId)); }
        if (from.HasValue) { sql += " AND service_date >= @f"; ps.Add(PDate("f", from.Value)); }
        if (to.HasValue) { sql += " AND service_date <= @t"; ps.Add(PDate("t", to.Value)); }
        return Convert.ToDecimal(Scalar(sql, ps.ToArray()));
    }

    public DataTable GetExpenseSummary(int vehicleId, DateTime? from, DateTime? to)
    {
        string join = "";
        var ps = new List<NpgsqlParameter>();
        if (from.HasValue) { join += " AND r.service_date >= @f"; ps.Add(PDate("f", from.Value)); }
        if (to.HasValue) { join += " AND r.service_date <= @t"; ps.Add(PDate("t", to.Value)); }
        string where = "";
        if (vehicleId > 0) { where = " WHERE v.vehicle_id=@v"; ps.Add(P("v", vehicleId)); }

        string sql = $@"
            SELECT v.registration_number AS ""Vehicle"",
                   v.make || ' ' || v.model AS ""Make / Model"",
                   COUNT(r.record_id) AS ""Services"",
                   COALESCE(SUM(r.cost), 0) AS ""Cost (RWF)""
            FROM vehicles v
            LEFT JOIN service_records r ON r.vehicle_id = v.vehicle_id{join}
            {where}
            GROUP BY v.vehicle_id, v.registration_number, v.make, v.model
            ORDER BY 4 DESC, 1";
        return Query(sql, ps.ToArray());
    }

    public DashboardSummary GetSummary()
    {
        var dt = Query($@"
            SELECT (SELECT COUNT(*) FROM vehicles) AS vehicles,
                   (SELECT COUNT(*) FROM maintenance_schedules s JOIN vehicles v ON v.vehicle_id=s.vehicle_id
                     WHERE {AlertSql} = 'Upcoming') AS upcoming,
                   (SELECT COUNT(*) FROM maintenance_schedules s JOIN vehicles v ON v.vehicle_id=s.vehicle_id
                     WHERE {AlertSql} = 'Overdue') AS overdue,
                   (SELECT COALESCE(SUM(cost),0) FROM service_records
                     WHERE service_date >= date_trunc('year', CURRENT_DATE)) AS cost");
        var r = dt.Rows[0];
        return new DashboardSummary
        {
            Vehicles = Convert.ToInt32(r["vehicles"]),
            Upcoming = Convert.ToInt32(r["upcoming"]),
            Overdue = Convert.ToInt32(r["overdue"]),
            CostThisYear = Convert.ToDecimal(r["cost"])
        };
    }

    public DataTable GetRecent(int count) => Query($@"
        SELECT r.service_date AS ""Date"",
               v.registration_number AS ""Vehicle"",
               r.maintenance_type AS ""Type"",
               r.service_provider AS ""Provider"",
               r.cost AS ""Cost (RWF)"",
               r.description AS ""Description""
        FROM service_records r JOIN vehicles v ON v.vehicle_id = r.vehicle_id
        ORDER BY r.created_at DESC, r.record_id DESC
        LIMIT {count}");
}
