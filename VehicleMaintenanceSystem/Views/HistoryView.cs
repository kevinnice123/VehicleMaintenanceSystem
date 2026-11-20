using System.Windows.Forms;
using System.Data;
using System.Text;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;

namespace VehicleMaintenanceSystem.Views;

public partial class HistoryView : UserControl
{
    private readonly MaintenanceController _controller = new();
    private readonly VehicleController _vehicles = new();

    public HistoryView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgv);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        UiHelper.Guard(() =>
        {
            UiHelper.BindVehicles(cboVehicle, _vehicles.GetLookup(true));
            LoadHistory();
        });
    }

    private void LoadHistory()
    {
        DateTime? from = UiHelper.OptionalDate(dtpFrom);
        DateTime? to = UiHelper.OptionalDate(dtpTo);

        var range = _controller.ValidateRange(from, to);
        if (!range.Success) { UiHelper.Error(range.Message); return; }

        int vehicleId = UiHelper.SelectedVehicleId(cboVehicle);
        dgv.DataSource = _controller.GetHistory(vehicleId, from, to);
        decimal total = _controller.GetTotalCost(vehicleId, from, to);
        lblTotal.Text = "Total maintenance expenses: " + total.ToString("N2") + " RWF";
        txtDetails.Text = dgv.Rows.Count == 0 ? "No maintenance records found for this selection." : "";
        if (dgv.Rows.Count > 0) ShowDetails();
    }

    private void btnShow_Click(object sender, EventArgs e) => UiHelper.Guard(LoadHistory);

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
        if (DesignMode) return;
        ShowDetails();
    }

    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        ShowDetails();
        UiHelper.Info(txtDetails.Text);
    }

    private void ShowDetails()
    {
        if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0) return;
        var sb = new StringBuilder();
        foreach (DataGridViewColumn col in dgv.Columns)
        {
            object value = dgv.CurrentRow.Cells[col.Index].Value;
            string text = value is DateTime d ? d.ToString("yyyy-MM-dd")
                        : value is decimal m ? m.ToString("N2") : Convert.ToString(value);
            sb.AppendLine(col.HeaderText + ": " + text);
        }
        txtDetails.Text = sb.ToString();
    }
}
