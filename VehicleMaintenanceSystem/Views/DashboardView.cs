using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;

namespace VehicleMaintenanceSystem.Views;

public partial class DashboardView : UserControl
{
    private readonly DashboardController _controller = new();

    public DashboardView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgvAlerts);
        UiHelper.FormatGrid(dgvRecent);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        lblWelcome.Text = "Welcome, " + Session.CurrentUser.FullName + " (" + Session.CurrentUser.Role + ")";
        UiHelper.Guard(() =>
        {
            var s = _controller.GetSummary();
            lblVehiclesValue.Text = s.Vehicles.ToString();
            lblUpcomingValue.Text = s.Upcoming.ToString();
            lblOverdueValue.Text = s.Overdue.ToString();
            lblCostValue.Text = s.CostThisYear.ToString("N0");
            dgvAlerts.DataSource = _controller.GetAlerts();
            dgvRecent.DataSource = _controller.GetRecent();
        });
    }
}
