namespace VehicleMaintenanceSystem;

using VehicleMaintenanceSystem.Data;
using VehicleMaintenanceSystem.Views;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            DbInitializer.Initialize();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Could not connect to PostgreSQL.\n\n" + ex.Message +
                "\n\nMake sure PostgreSQL is running on localhost:5432 and the password in Data/Db.cs is correct.",
                "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        while (true)
        {
            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK) break;
            }

            using var main = new MainForm();
            Application.Run(main);
            if (!main.LoggedOut) break;
        }
    }
}
