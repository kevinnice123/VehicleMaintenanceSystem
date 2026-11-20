namespace VehicleMaintenanceSystem.Views
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShow = new CheckBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            lblHint = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Vehicle Maintenance System";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(20, 70);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 15);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Username or email";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(20, 92);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(330, 23);
            txtLogin.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 152);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShow
            // 
            chkShow.AutoSize = true;
            chkShow.Location = new Point(20, 186);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(108, 19);
            chkShow.TabIndex = 5;
            chkShow.Text = "Show password";
            chkShow.CheckedChanged += chkShow_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(20, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 32);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(20, 260);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(330, 32);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(20, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(330, 32);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(20, 345);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(191, 15);
            lblHint.TabIndex = 9;
            lblHint.Text = "First-time login: admin / admin123";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 380);
            Controls.Add(lblTitle);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShow);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(btnExit);
            Controls.Add(lblHint);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Vehicle Maintenance System";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHint;
    }
}
