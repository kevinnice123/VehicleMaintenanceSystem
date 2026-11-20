namespace VehicleMaintenanceSystem.Models;

public class Driver
{
    public int DriverId { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string LicenceNumber { get; set; }
    public string LicenceCategory { get; set; }
    public DateTime LicenceExpiry { get; set; }
}
