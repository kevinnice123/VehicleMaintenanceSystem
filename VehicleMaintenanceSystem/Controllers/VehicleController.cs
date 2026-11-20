using System.Data;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class VehicleController : ControllerBase
{
    private readonly VehicleRepository _repo = new();

    public DataTable Search(string term) => _repo.Search(term);

    public Vehicle Get(int id) => _repo.GetById(id);

    public DataTable GetLookup(bool includeAll)
    {
        var dt = _repo.GetLookup();
        if (includeAll)
        {
            var row = dt.NewRow();
            row["vehicle_id"] = 0;
            row["display"] = "All vehicles";
            dt.Rows.InsertAt(row, 0);
        }
        return dt;
    }

    public OperationResult Save(Vehicle v)
    {
        if (!Session.CanManageVehicles) return Deny();

        v.RegistrationNumber = (v.RegistrationNumber ?? "").Trim().ToUpperInvariant();
        v.Make = (v.Make ?? "").Trim();
        v.Model = (v.Model ?? "").Trim();

        if (v.RegistrationNumber.Length == 0) return OperationResult.Fail("Registration number is required.");
        if (v.Make.Length == 0) return OperationResult.Fail("Make is required.");
        if (v.Model.Length == 0) return OperationResult.Fail("Model is required.");
        if (string.IsNullOrWhiteSpace(v.VehicleType)) return OperationResult.Fail("Select the vehicle type.");
        if (v.Year < 1950 || v.Year > DateTime.Today.Year + 1)
            return OperationResult.Fail($"Year must be between 1950 and {DateTime.Today.Year + 1}.");
        if (v.Mileage < 0) return OperationResult.Fail("Mileage cannot be negative.");

        return Try(() =>
        {
            if (_repo.RegistrationExists(v.RegistrationNumber, v.VehicleId))
                return OperationResult.Fail("A vehicle with this registration number already exists.");

            if (v.VehicleId == 0)
            {
                int id = _repo.Insert(v);
                return OperationResult.Ok("Vehicle registered.", id);
            }
            _repo.Update(v);
            return OperationResult.Ok("Vehicle updated.", v.VehicleId);
        });
    }
}
