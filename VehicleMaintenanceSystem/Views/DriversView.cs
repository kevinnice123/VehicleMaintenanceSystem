using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Views;

public partial class DriversView : UserControl
{
    private readonly DriverController _controller = new();
    private readonly VehicleController _vehicles = new();
    private int _currentId;

    public DriversView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgv);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        cboCategory.Items.AddRange(Lookups.LicenceCategories);
        cboCategory.SelectedIndex = 1;
        dtpExpiry.Value = DateTime.Today.AddYears(1);

        bool canEdit = Session.CanManageDrivers;
        gbDetails.Enabled = canEdit;
        gbAssign.Enabled = canEdit;

        UiHelper.Guard(() =>
        {
            UiHelper.BindVehicles(cboVehicle, _vehicles.GetLookup(false));
            LoadGrid(null);
        });
    }

    private void LoadGrid(int? selectId)
    {
        dgv.DataSource = _controller.Search(txtSearch.Text);
        UiHelper.HideColumns(dgv, "driver_id");
        if (selectId.HasValue) UiHelper.SelectRowById(dgv, "driver_id", selectId.Value);
        else dgv.ClearSelection();
    }

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
        if (DesignMode) return;
        int? id = UiHelper.SelectedId(dgv, "driver_id");
        if (id == null || dgv.SelectedRows.Count == 0) return;

        var d = _controller.Get(id.Value);
        if (d == null) return;
        _currentId = d.DriverId;
        txtName.Text = d.FullName;
        txtPhone.Text = d.Phone;
        txtEmail.Text = d.Email;
        txtLicence.Text = d.LicenceNumber;
        cboCategory.SelectedItem = d.LicenceCategory;
        dtpExpiry.Value = d.LicenceExpiry < dtpExpiry.MinDate ? dtpExpiry.MinDate : d.LicenceExpiry;
        lblDriverName.Text = d.FullName;
    }

    private void btnSearch_Click(object sender, EventArgs e) => UiHelper.Guard(() => LoadGrid(null));

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        UiHelper.Guard(() => LoadGrid(null));
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnSearch_Click(sender, e); }
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        _currentId = 0;
        txtName.Clear(); txtPhone.Clear(); txtEmail.Clear(); txtLicence.Clear();
        cboCategory.SelectedIndex = 1;
        dtpExpiry.Value = DateTime.Today.AddYears(1);
        lblDriverName.Text = "(select a driver in the table)";
        dgv.ClearSelection();
        txtName.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var d = new Driver
        {
            DriverId = _currentId,
            FullName = txtName.Text,
            Phone = txtPhone.Text,
            Email = txtEmail.Text,
            LicenceNumber = txtLicence.Text,
            LicenceCategory = cboCategory.SelectedItem?.ToString(),
            LicenceExpiry = dtpExpiry.Value.Date
        };

        var result = _controller.Save(d);
        if (!UiHelper.Show(result)) return;
        _currentId = result.Id;
        UiHelper.Guard(() => LoadGrid(result.Id));
    }

    private void btnAssign_Click(object sender, EventArgs e)
    {
        var result = _controller.Assign(UiHelper.SelectedVehicleId(cboVehicle), _currentId);
        if (UiHelper.Show(result)) UiHelper.Guard(() => LoadGrid(_currentId == 0 ? null : _currentId));
    }

    private void btnUnassign_Click(object sender, EventArgs e)
    {
        var result = _controller.Unassign(UiHelper.SelectedVehicleId(cboVehicle));
        if (UiHelper.Show(result)) UiHelper.Guard(() => LoadGrid(_currentId == 0 ? null : _currentId));
    }
}
