using System.Data;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class DashboardController : ControllerBase
{
    private readonly MaintenanceRepository _repo = new();

    public DashboardSummary GetSummary() => _repo.GetSummary();
    public DataTable GetAlerts() => _repo.GetDueAlerts(0, null, null);
    public DataTable GetRecent() => _repo.GetRecent(10);
}
