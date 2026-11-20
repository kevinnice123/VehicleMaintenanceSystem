namespace VehicleMaintenanceSystem.Models;

public class MaintenanceSchedule
{
    public int ScheduleId { get; set; }
    public int VehicleId { get; set; }
    public DateTime PlannedDate { get; set; }
    public int ExpectedMileage { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = MaintenanceStatus.Planned;
}
