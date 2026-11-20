using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;
using VehicleMaintenanceSystem.Helpers;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Views;

public partial class UsersView : UserControl
{
    private readonly UserController _controller = new();
    private int _currentId;
    private bool _currentActive = true;

    public UsersView()
    {
        InitializeComponent();
        UiHelper.FormatGrid(dgv);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (DesignMode || !Session.IsAuthenticated) return;

        cboRole.Items.AddRange(Roles.All);
        cboRole.SelectedIndex = 1;
        btnToggle.Enabled = false;
        UiHelper.Guard(() => LoadGrid(null));
    }

    private void LoadGrid(int? selectId)
    {
        dgv.DataSource = _controller.GetUsers();
        UiHelper.HideColumns(dgv, "user_id");
        if (selectId.HasValue) UiHelper.SelectRowById(dgv, "user_id", selectId.Value);
        else dgv.ClearSelection();
    }

    private void dgv_SelectionChanged(object sender, EventArgs e)
    {
        if (DesignMode) return;
        int? id = UiHelper.SelectedId(dgv, "user_id");
        if (id == null || dgv.SelectedRows.Count == 0) return;

        var u = _controller.Get(id.Value);
        if (u == null) return;
        _currentId = u.UserId;
        _currentActive = u.IsActive;
        txtFullName.Text = u.FullName;
        txtUsername.Text = u.Username;
        txtEmail.Text = u.Email;
        txtPassword.Clear();
        cboRole.SelectedItem = u.Role;
        lblMode.Text = "Editing " + u.Username + (u.IsActive ? "" : "  (deactivated)");
        btnToggle.Text = u.IsActive ? "Deactivate" : "Activate";
        btnToggle.Enabled = true;
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        _currentId = 0;
        txtFullName.Clear(); txtUsername.Clear(); txtEmail.Clear(); txtPassword.Clear();
        cboRole.SelectedIndex = 1;
        lblMode.Text = "New user";
        btnToggle.Text = "Deactivate";
        btnToggle.Enabled = false;
        dgv.ClearSelection();
        txtFullName.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var u = new User
        {
            UserId = _currentId,
            FullName = txtFullName.Text,
            Username = txtUsername.Text,
            Email = txtEmail.Text,
            Role = cboRole.SelectedItem?.ToString(),
            IsActive = _currentActive
        };

        var result = _controller.Save(u, txtPassword.Text);
        if (!UiHelper.Show(result)) return;
        _currentId = result.Id;
        UiHelper.Guard(() => LoadGrid(result.Id));
    }

    private void btnToggle_Click(object sender, EventArgs e)
    {
        if (_currentId == 0) return;
        bool activate = !_currentActive;
        if (!UiHelper.Confirm(activate ? "Activate this account?" : "Deactivate this account? The user will no longer be able to log in."))
            return;

        var result = _controller.SetActive(_currentId, activate);
        if (!UiHelper.Show(result)) return;
        UiHelper.Guard(() => LoadGrid(_currentId));
    }
}
