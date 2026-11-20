namespace VehicleMaintenanceSystem.Models;

public class DashboardSummary
{
    public int Vehicles { get; set; }
    public int Upcoming { get; set; }
    public int Overdue { get; set; }
    public decimal CostThisYear { get; set; }
}
