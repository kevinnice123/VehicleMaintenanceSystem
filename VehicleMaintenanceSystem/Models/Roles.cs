namespace VehicleMaintenanceSystem.Models;

public static class Roles
{
    public const string Administrator = "Administrator";
    public const string FleetManager = "Fleet Manager";
    public const string MaintenanceOfficer = "Maintenance Officer";
    public const string Management = "Management";

    public static readonly string[] All = { Administrator, FleetManager, MaintenanceOfficer, Management };
}

public static class MaintenanceStatus
{
    public const string Planned = "Planned";
    public const string InProgress = "In Progress";
    public const string Completed = "Completed";
    public const string Cancelled = "Cancelled";

    public static readonly string[] All = { Planned, InProgress, Completed, Cancelled };
}

public static class Lookups
{
    public static readonly string[] VehicleTypes =
        { "Sedan", "SUV", "Pickup", "Van", "Minibus", "Bus", "Truck", "Motorcycle", "Other" };

    public static readonly string[] MaintenanceTypes =
        { "Routine Service", "Oil Change", "Repair", "Brake Service", "Tire Replacement",
          "Battery", "Inspection", "Body Work", "Other" };

    public static readonly string[] LicenceCategories = { "A", "B", "C", "D", "E", "F" };
}
