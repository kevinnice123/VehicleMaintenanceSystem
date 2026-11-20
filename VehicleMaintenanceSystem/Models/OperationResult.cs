namespace VehicleMaintenanceSystem.Models;

public class OperationResult
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Id { get; set; }

    public static OperationResult Ok(string message, int id = 0) => new() { Success = true, Message = message, Id = id };
    public static OperationResult Fail(string message) => new() { Success = false, Message = message };
}
