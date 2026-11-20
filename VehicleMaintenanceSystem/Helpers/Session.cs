using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Helpers;

public static class Session
{
    public static User CurrentUser { get; set; }

    public static bool IsAuthenticated => CurrentUser != null;

    private static bool Is(params string[] roles) =>
        CurrentUser != null && Array.IndexOf(roles, CurrentUser.Role) >= 0;

    public static bool CanManageUsers => Is(Roles.Administrator);
    public static bool CanManageVehicles => Is(Roles.Administrator, Roles.FleetManager);
    public static bool CanManageDrivers => Is(Roles.Administrator, Roles.FleetManager);
    public static bool CanSchedule => Is(Roles.Administrator, Roles.FleetManager);
    public static bool CanRecordMaintenance => Is(Roles.Administrator, Roles.MaintenanceOfficer);
    public static bool CanUpdateStatus => Is(Roles.Administrator, Roles.FleetManager, Roles.MaintenanceOfficer);
}
