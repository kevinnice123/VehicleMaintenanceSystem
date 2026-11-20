using System.Windows.Forms;
using System.Drawing;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;

namespace VehicleMaintenanceSystem.Views;

public partial class MainForm : Form
{
    private readonly AuthController _auth = new();
    private readonly List<Button> _navButtons = new();

    public bool LoggedOut { get; private set; }

    public MainForm()
    {
        InitializeComponent();
        _navButtons.AddRange(new[] { btnDashboard, btnVehicles, btnDrivers, btnMaintenance, btnHistory, btnReports, btnUsers });
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        lblUser.Text = Session.CurrentUser.FullName + "   |   " + Session.CurrentUser.Role;
        btnUsers.Visible = Session.CanManageUsers;
        ShowView(btnDashboard, "Dashboard", () => new DashboardView());
    }

    private void ShowView(Button active, string title, Func<UserControl> create)
    {
        foreach (var b in _navButtons) b.Font = new Font(Font, FontStyle.Regular);
        active.Font = new Font(Font, FontStyle.Bold);

        foreach (Control old in pnlContent.Controls.Cast<Control>().ToList())
        {
            pnlContent.Controls.Remove(old);
            old.Dispose();
        }

        var view = create();
        view.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(view);
        lblPageTitle.Text = title;
    }

    private void btnDashboard_Click(object sender, EventArgs e) => ShowView(btnDashboard, "Dashboard", () => new DashboardView());
    private void btnVehicles_Click(object sender, EventArgs e) => ShowView(btnVehicles, "Vehicles", () => new VehiclesView());
    private void btnDrivers_Click(object sender, EventArgs e) => ShowView(btnDrivers, "Drivers", () => new DriversView());
    private void btnMaintenance_Click(object sender, EventArgs e) => ShowView(btnMaintenance, "Maintenance", () => new MaintenanceView());
    private void btnHistory_Click(object sender, EventArgs e) => ShowView(btnHistory, "Service History", () => new HistoryView());
    private void btnReports_Click(object sender, EventArgs e) => ShowView(btnReports, "Reports", () => new ReportsView());
    private void btnUsers_Click(object sender, EventArgs e) => ShowView(btnUsers, "User Accounts", () => new UsersView());

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (!UiHelper.Confirm("Do you want to log out?")) return;
        _auth.Logout();
        LoggedOut = true;
        Close();
    }
}
