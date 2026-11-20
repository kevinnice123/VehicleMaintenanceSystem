namespace VehicleMaintenanceSystem.Models;

public class Vehicle
{
    public int VehicleId { get; set; }
    public string RegistrationNumber { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string VehicleType { get; set; }
    public int Mileage { get; set; }
    public int? DriverId { get; set; }
}
