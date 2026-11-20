using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Views;

public partial class MaintenanceView : UserControl
{
    private readonly MaintenanceController _controller = new();
    private readonly VehicleController _vehicles = new();
    private int? _linkedScheduleId;
    private bool _loading = true;

    public MaintenanceView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgvSchedules);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        cboStatusFilter.Items.Add("All");
        cboStatusFilter.Items.AddRange(MaintenanceStatus.All);
        cboStatusFilter.SelectedIndex = 0;
        cboNewStatus.Items.AddRange(MaintenanceStatus.All);
        cboNewStatus.SelectedIndex = 1;
        cboRType.Items.AddRange(Lookups.MaintenanceTypes);
        cboRType.SelectedIndex = 0;
        dtpPlanned.Value = DateTime.Today.AddDays(30);
        dtpServiceDate.Value = DateTime.Today;

        gbSchedule.Enabled = Session.CanSchedule;
        gbRecord.Enabled = Session.CanRecordMaintenance;
        cboNewStatus.Enabled = btnUpdateStatus.Enabled = Session.CanUpdateStatus;

        UiHelper.Guard(() =>
        {
            UiHelper.BindVehicles(cboSVehicle, _vehicles.GetLookup(false));
            UiHelper.BindVehicles(cboRVehicle, _vehicles.GetLookup(false));
            _loading = false;
            LoadSchedules();
        });
        _loading = false;
    }

    private void LoadSchedules()
    {
        string status = cboStatusFilter.SelectedIndex <= 0 ? null : cboStatusFilter.SelectedItem.ToString();
        dgvSchedules.DataSource = _controller.GetSchedules(0, status);
        UiHelper.HideColumns(dgvSchedules, "schedule_id", "vehicle_id");
    }

    private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_loading || DesignMode) return;
        UiHelper.Guard(LoadSchedules);
    }

    private void btnSchedule_Click(object sender, EventArgs e)
    {
        var s = new MaintenanceSchedule
        {
            VehicleId = UiHelper.SelectedVehicleId(cboSVehicle),
            PlannedDate = dtpPlanned.Value.Date,
            ExpectedMileage = (int)nudExpMileage.Value,
            Description = txtSDesc.Text
        };

        var result = _controller.Schedule(s);
        if (!UiHelper.Show(result)) return;

        txtSDesc.Clear();
        nudExpMileage.Value = 0;
        UiHelper.Guard(LoadSchedules);
    }

    private void btnUpdateStatus_Click(object sender, EventArgs e)
    {
        int? id = UiHelper.SelectedId(dgvSchedules, "schedule_id");
        if (id == null) { UiHelper.Error("Select a maintenance item in the table first."); return; }

        string status = cboNewStatus.SelectedItem?.ToString();

        var row = dgvSchedules.CurrentRow;
        int vehicleId = Convert.ToInt32(row.Cells["vehicle_id"].Value);
        decimal mileage = Convert.ToDecimal(row.Cells["Current Mileage"].Value);
        string description = Convert.ToString(row.Cells["Description"].Value);
        string plate = Convert.ToString(row.Cells["Vehicle"].Value);

        var result = _controller.UpdateStatus(id.Value, status);
        if (!UiHelper.Show(result)) return;

        UiHelper.Guard(LoadSchedules);

        if (status == MaintenanceStatus.Completed && Session.CanRecordMaintenance &&
            UiHelper.Confirm("Record the service details (provider, cost, mileage) now?"))
        {
            _linkedScheduleId = id.Value;
            cboRVehicle.SelectedValue = vehicleId;
            nudRMileage.Value = Math.Min(mileage, nudRMileage.Maximum);
            txtRDesc.Text = description;
            lblLinked.Text = "Linked schedule: #" + id.Value + " (" + plate + ")";
            tabs.SelectedTab = tabRecord;
        }
    }

    private void btnSaveRecord_Click(object sender, EventArgs e)
    {
        var r = new ServiceRecord
        {
            VehicleId = UiHelper.SelectedVehicleId(cboRVehicle),
            ScheduleId = _linkedScheduleId,
            ServiceDate = dtpServiceDate.Value.Date,
            Mileage = (int)nudRMileage.Value,
            MaintenanceType = cboRType.SelectedItem?.ToString(),
            ServiceProvider = txtProvider.Text,
            Cost = nudCost.Value,
            Description = txtRDesc.Text
        };

        var result = _controller.Record(r);
        if (!UiHelper.Show(result)) return;

        ClearRecordForm();
        UiHelper.Guard(LoadSchedules);
    }

    private void btnClearRecord_Click(object sender, EventArgs e) => ClearRecordForm();

    private void ClearRecordForm()
    {
        _linkedScheduleId = null;
        lblLinked.Text = "Linked schedule: none";
        txtProvider.Clear();
        txtRDesc.Clear();
        nudCost.Value = 0;
        nudRMileage.Value = 0;
        dtpServiceDate.Value = DateTime.Today;
        cboRType.SelectedIndex = 0;
    }
}
