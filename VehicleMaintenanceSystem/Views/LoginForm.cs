using System.Windows.Forms;
using VehicleMaintenanceSystem.Controllers;

namespace VehicleMaintenanceSystem.Views;

public partial class LoginForm : Form
{
    private readonly AuthController _auth = new();

    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var result = _auth.Login(txtLogin.Text, txtPassword.Text);
        if (!result.Success)
        {
            UiHelper.Error(result.Message);
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        using var form = new RegisterForm();
        if (form.ShowDialog(this) == DialogResult.OK)
        {
            txtLogin.Text = form.NewUsername;
            txtPassword.Clear();
            txtPassword.Focus();
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void chkShow_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShow.Checked;
    }
}
