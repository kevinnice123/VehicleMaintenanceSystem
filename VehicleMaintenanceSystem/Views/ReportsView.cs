using System.Windows.Forms;
using System.Data;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;

namespace VehicleMaintenanceSystem.Views;

public partial class ReportsView : UserControl
{
    private readonly ReportController _controller = new();
    private readonly VehicleController _vehicles = new();
    private readonly MaintenanceController _maintenance = new();

    public ReportsView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgv);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        cboReport.Items.AddRange(ReportController.ReportTypes);
        cboReport.SelectedIndex = 0;
        UiHelper.Guard(() => UiHelper.BindVehicles(cboVehicle, _vehicles.GetLookup(true)));
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        DateTime? from = UiHelper.OptionalDate(dtpFrom);
        DateTime? to = UiHelper.OptionalDate(dtpTo);

        var range = _maintenance.ValidateRange(from, to);
        if (!range.Success) { UiHelper.Error(range.Message); return; }

        UiHelper.Guard(() =>
        {
            var table = _controller.Generate(cboReport.SelectedItem.ToString(),
                UiHelper.SelectedVehicleId(cboVehicle), from, to);
            dgv.DataSource = table;
            lblSummary.Text = cboReport.SelectedItem + ":  " + ReportController.Summarize(table);
        });
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        if (dgv.DataSource is not DataTable table || table.Rows.Count == 0)
        {
            UiHelper.Error("Generate a report with at least one row first.");
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Filter = "CSV file (*.csv)|*.csv",
            FileName = cboReport.SelectedItem.ToString().Replace(' ', '_') + "_" + DateTime.Today.ToString("yyyyMMdd") + ".csv"
        };
        if (dialog.ShowDialog() != DialogResult.OK) return;

        UiHelper.Show(_controller.ExportCsv(table, dialog.FileName));
    }
}
