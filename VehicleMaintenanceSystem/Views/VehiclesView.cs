using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Views;

public partial class VehiclesView : UserControl
{
    private readonly VehicleController _controller = new();
    private int _currentId;

    public VehiclesView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgv);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        cboType.Items.AddRange(Lookups.VehicleTypes);
        cboType.SelectedIndex = 0;

        bool canEdit = Session.CanManageVehicles;
        foreach (Control c in gbDetails.Controls) if (c != lblMode) c.Enabled = canEdit;
        if (!canEdit) lblMode.Text = "View only - your role cannot change vehicle records.";

        UiHelper.Guard(() => LoadGrid(null));
    }

    private void LoadGrid(int? selectId)
    {
        dgv.DataSource = _controller.Search(txtSearch.Text);
        UiHelper.HideColumns(dgv, "vehicle_id");
        if (selectId.HasValue) UiHelper.SelectRowById(dgv, "vehicle_id", selectId.Value);
        else if (_currentId == 0) { dgv.ClearSelection(); }
    }

    private void ClearForm()
    {
        _currentId = 0;
        txtReg.Clear(); txtMake.Clear(); txtModel.Clear();
        nudYear.Value = DateTime.Today.Year; nudMileage.Value = 0;
        cboType.SelectedIndex = 0;
        dgv.ClearSelection();
        if (Session.CanManageVehicles) lblMode.Text = "New vehicle";
        txtReg.Focus();
    }

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
        if (DesignMode) return;
        int? id = UiHelper.SelectedId(dgv, "vehicle_id");
        if (id == null || dgv.SelectedRows.Count == 0) return;

        var v = _controller.Get(id.Value);
        if (v == null) return;
        _currentId = v.VehicleId;
        txtReg.Text = v.RegistrationNumber;
        txtMake.Text = v.Make;
        txtModel.Text = v.Model;
        nudYear.Value = Math.Min(Math.Max(v.Year, (int)nudYear.Minimum), (int)nudYear.Maximum);
        nudMileage.Value = v.Mileage;
        cboType.SelectedItem = v.VehicleType;
        if (cboType.SelectedIndex < 0) cboType.SelectedIndex = 0;
        if (Session.CanManageVehicles) lblMode.Text = "Editing vehicle " + v.RegistrationNumber;
    }

    private void btnSearch_Click(object sender, EventArgs e) => UiHelper.Guard(() => { _currentId = 0; LoadGrid(null); });

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        txtSearch.Clear();
        UiHelper.Guard(() => { _currentId = 0; LoadGrid(null); });
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; btnSearch_Click(sender, e); }
    }

    private void btnNew_Click(object sender, EventArgs e) => ClearForm();

    private void btnSave_Click(object sender, EventArgs e)
    {
        var v = new Vehicle
        {
            VehicleId = _currentId,
            RegistrationNumber = txtReg.Text,
            Make = txtMake.Text,
            Model = txtModel.Text,
            Year = (int)nudYear.Value,
            VehicleType = cboType.SelectedItem?.ToString(),
            Mileage = (int)nudMileage.Value
        };

        var result = _controller.Save(v);
        if (!UiHelper.Show(result)) return;

        _currentId = result.Id;
        UiHelper.Guard(() => LoadGrid(result.Id));
    }
}
