using System.Data;
using System.Text;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Models;
using static VehicleMaintenanceSystem.Data.Db;

namespace VehicleMaintenanceSystem.Controllers;

public class ReportController : ControllerBase
{
    public const string RegisteredVehicles = "Registered Vehicles";
    public const string MaintenanceHistory = "Maintenance History";
    public const string DueServices = "Upcoming and Overdue Services";
    public const string Expenses = "Maintenance Expenses";

    public static readonly string[] ReportTypes = { RegisteredVehicles, MaintenanceHistory, DueServices, Expenses };

    private readonly MaintenanceRepository _maintenance = new();

    public DataTable Generate(string report, int vehicleId, DateTime? from, DateTime? to)
    {
        switch (report)
        {
            case RegisteredVehicles:
                string sql = @"
                    SELECT v.registration_number AS ""Reg. No"", v.make AS ""Make"", v.model AS ""Model"",
                           v.manufacture_year AS ""Year"", v.vehicle_type AS ""Type"", v.mileage AS ""Mileage (km)"",
                           COALESCE(d.full_name, 'Unassigned') AS ""Driver""
                    FROM vehicles v LEFT JOIN drivers d ON d.driver_id = v.driver_id";
                if (vehicleId > 0)
                    return Query(sql + " WHERE v.vehicle_id=@v ORDER BY v.registration_number", P("v", vehicleId));
                return Query(sql + " ORDER BY v.registration_number");

            case MaintenanceHistory:
                return _maintenance.GetHistory(vehicleId, from, to);

            case DueServices:
                return _maintenance.GetDueAlerts(vehicleId, from, to);

            case Expenses:
                return _maintenance.GetExpenseSummary(vehicleId, from, to);

            default:
                return new DataTable();
        }
    }

    public static string Summarize(DataTable table)
    {
        string text = table.Rows.Count + " record(s)";
        string costColumn = table.Columns.Contains("Cost (RWF)") ? "Cost (RWF)" : null;
        if (costColumn != null && table.Rows.Count > 0)
        {
            decimal total = 0;
            foreach (DataRow r in table.Rows)
                if (r[costColumn] != DBNull.Value) total += Convert.ToDecimal(r[costColumn]);
            text += "   |   Total cost: " + total.ToString("N2") + " RWF";
        }
        return text;
    }

    public OperationResult ExportCsv(DataTable table, string path)
    {
        if (table == null || table.Columns.Count == 0) return OperationResult.Fail("There is nothing to export.");
        try
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(",", table.Columns.Cast<DataColumn>().Select(c => Quote(c.ColumnName))));
            foreach (DataRow row in table.Rows)
            {
                sb.AppendLine(string.Join(",", row.ItemArray.Select(v =>
                    v is DateTime dt ? Quote(dt.ToString("yyyy-MM-dd")) : Quote(Convert.ToString(v)))));
            }
            File.WriteAllText(path, sb.ToString(), new UTF8Encoding(true));
            return OperationResult.Ok("Report exported to " + path);
        }
        catch (Exception ex)
        {
            return OperationResult.Fail("Could not export: " + ex.Message);
        }
    }

    private static string Quote(string s) => "\"" + (s ?? "").Replace("\"", "\"\"") + "\"";
}
