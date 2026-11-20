using System.Data;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class DriverController : ControllerBase
{
    private readonly DriverRepository _drivers = new();
    private readonly VehicleRepository _vehicles = new();

    public DataTable Search(string term) => _drivers.Search(term);

    public Driver Get(int id) => _drivers.GetById(id);

    public OperationResult Save(Driver d)
    {
        if (!Session.CanManageDrivers) return Deny();

        d.FullName = (d.FullName ?? "").Trim();
        d.Phone = (d.Phone ?? "").Trim();
        d.Email = (d.Email ?? "").Trim();
        d.LicenceNumber = (d.LicenceNumber ?? "").Trim().ToUpperInvariant();

        if (d.FullName.Length == 0) return OperationResult.Fail("Driver name is required.");
        if (d.Phone.Length == 0) return OperationResult.Fail("Phone number is required.");
        if (d.Email.Length > 0 && !IsValidEmail(d.Email)) return OperationResult.Fail("Enter a valid email address.");
        if (d.LicenceNumber.Length == 0) return OperationResult.Fail("Licence number is required.");
        if (string.IsNullOrWhiteSpace(d.LicenceCategory)) return OperationResult.Fail("Select the licence category.");
        if (d.LicenceExpiry.Date < DateTime.Today) return OperationResult.Fail("The licence has expired. Enter a valid expiry date.");

        return Try(() =>
        {
            if (_drivers.LicenceExists(d.LicenceNumber, d.DriverId))
                return OperationResult.Fail("A driver with this licence number already exists.");

            if (d.DriverId == 0)
            {
                int id = _drivers.Insert(d);
                return OperationResult.Ok("Driver registered.", id);
            }
            _drivers.Update(d);
            return OperationResult.Ok("Driver updated.", d.DriverId);
        });
    }

    public OperationResult Assign(int vehicleId, int driverId)
    {
        if (!Session.CanManageDrivers) return Deny();
        if (vehicleId <= 0) return OperationResult.Fail("Select a vehicle.");
        if (driverId <= 0) return OperationResult.Fail("Select a driver in the table first.");

        return Try(() =>
        {
            _vehicles.SetDriver(vehicleId, driverId);
            return OperationResult.Ok("Driver assigned to the vehicle.");
        });
    }

    public OperationResult Unassign(int vehicleId)
    {
        if (!Session.CanManageDrivers) return Deny();
        if (vehicleId <= 0) return OperationResult.Fail("Select a vehicle.");

        return Try(() =>
        {
            _vehicles.SetDriver(vehicleId, null);
            return OperationResult.Ok("Driver removed from the vehicle.");
        });
    }
}
