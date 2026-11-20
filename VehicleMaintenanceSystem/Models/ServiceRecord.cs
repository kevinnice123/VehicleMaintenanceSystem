namespace VehicleMaintenanceSystem.Models;

public class ServiceRecord
{
    public int RecordId { get; set; }
    public int VehicleId { get; set; }
    public int? ScheduleId { get; set; }
    public DateTime ServiceDate { get; set; }
    public int Mileage { get; set; }
    public string MaintenanceType { get; set; }
    public string Description { get; set; }
    public string ServiceProvider { get; set; }
    public decimal Cost { get; set; }
}
