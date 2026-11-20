using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;

namespace VehicleMaintenanceSystem.Views;

public partial class RegisterForm : Form
{
    private readonly AuthController _auth = new();

    public string NewUsername { get; private set; }

    public RegisterForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var result = _auth.Register(txtFullName.Text, txtUsername.Text, txtEmail.Text,
                                    txtPassword.Text, txtConfirm.Text);
        if (!UiHelper.Show(result)) return;

        NewUsername = txtUsername.Text.Trim();
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
