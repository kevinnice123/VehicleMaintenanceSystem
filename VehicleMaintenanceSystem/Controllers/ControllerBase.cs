using Npgsql;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Controllers;

public abstract class ControllerBase
{
    protected static OperationResult Deny() =>
        OperationResult.Fail("You do not have permission to perform this action.");

    protected static OperationResult Try(Func<OperationResult> action)
    {
        try
        {
            return action();
        }
        catch (PostgresException ex) when (ex.SqlState == "23505")
        {
            return OperationResult.Fail("A record with the same unique value already exists.");
        }
        catch (PostgresException ex) when (ex.SqlState == "23514")
        {
            return OperationResult.Fail("A value is outside the allowed range (check dates, costs and mileage).");
        }
        catch (Exception ex)
        {
            return OperationResult.Fail("Database error: " + ex.Message);
        }
    }

    protected static bool IsValidEmail(string email) =>
        !string.IsNullOrWhiteSpace(email) &&
        System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
}
