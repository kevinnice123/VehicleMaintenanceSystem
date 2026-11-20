using System.Data;
using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public class MaintenanceController : ControllerBase
{
    private readonly MaintenanceRepository _repo = new();
    private readonly VehicleRepository _vehicles = new();

    public DataTable GetSchedules(int vehicleId, string status) => _repo.GetSchedules(vehicleId, status);

    public OperationResult Schedule(MaintenanceSchedule s)
    {
        if (!Session.CanSchedule) return Deny();

        s.Description = (s.Description ?? "").Trim();
        if (s.VehicleId <= 0) return OperationResult.Fail("Select a vehicle.");
        if (s.PlannedDate.Date < DateTime.Today) return OperationResult.Fail("The planned service date cannot be in the past.");
        if (s.ExpectedMileage < 0) return OperationResult.Fail("Expected mileage cannot be negative.");
        if (s.Description.Length == 0) return OperationResult.Fail("Enter a service description.");

        return Try(() =>
        {
            s.Status = MaintenanceStatus.Planned;
            int id = _repo.InsertSchedule(s);
            return OperationResult.Ok("Maintenance scheduled.", id);
        });
    }

    public OperationResult UpdateStatus(int scheduleId, string status)
    {
        if (!Session.CanUpdateStatus) return Deny();
        if (scheduleId <= 0) return OperationResult.Fail("Select a maintenance item in the table.");
        if (Array.IndexOf(MaintenanceStatus.All, status) < 0) return OperationResult.Fail("Select a status.");

        return Try(() =>
        {
            _repo.UpdateStatus(scheduleId, status);
            return OperationResult.Ok("Status updated to " + status + ".", scheduleId);
        });
    }

    public OperationResult Record(ServiceRecord r)
    {
        if (!Session.CanRecordMaintenance) return Deny();

        r.Description = (r.Description ?? "").Trim();
        r.ServiceProvider = (r.ServiceProvider ?? "").Trim();

        if (r.VehicleId <= 0) return OperationResult.Fail("Select a vehicle.");
        if (r.ServiceDate.Date > DateTime.Today) return OperationResult.Fail("The service date cannot be in the future.");
        if (r.Mileage < 0) return OperationResult.Fail("Mileage cannot be negative.");
        if (string.IsNullOrWhiteSpace(r.MaintenanceType)) return OperationResult.Fail("Select the maintenance type.");
        if (r.Description.Length == 0) return OperationResult.Fail("Enter the work description.");
        if (r.ServiceProvider.Length == 0) return OperationResult.Fail("Enter the service provider.");
        if (r.Cost < 0) return OperationResult.Fail("Cost cannot be negative.");

        return Try(() =>
        {
            if (_vehicles.GetById(r.VehicleId) == null) return OperationResult.Fail("Vehicle not found.");
            int id = _repo.InsertRecord(r, Session.CurrentUser.UserId);
            return OperationResult.Ok("Maintenance record saved.", id);
        });
    }

    public DataTable GetHistory(int vehicleId, DateTime? from, DateTime? to) => _repo.GetHistory(vehicleId, from, to);

    public decimal GetTotalCost(int vehicleId, DateTime? from, DateTime? to) => _repo.GetTotalCost(vehicleId, from, to);

    public OperationResult ValidateRange(DateTime? from, DateTime? to)
    {
        if (from.HasValue && to.HasValue && from.Value.Date > to.Value.Date)
            return OperationResult.Fail("The 'From' date cannot be after the 'To' date.");
        return OperationResult.Ok("");
    }
}
