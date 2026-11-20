namespace VehicleMaintenanceSystem.Views
{
    partial class UsersView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPwdHint = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create accounts, assign roles and deactivate users (administrator only).";
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv.Location = new System.Drawing.Point(20, 55);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(950, 300);
            this.dgv.TabIndex = 1;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ReadOnly = true;
            this.dgv.MultiSelect = false;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblMode);
            this.gbDetails.Controls.Add(this.lblFull);
            this.gbDetails.Controls.Add(this.txtFullName);
            this.gbDetails.Controls.Add(this.lblUser);
            this.gbDetails.Controls.Add(this.txtUsername);
            this.gbDetails.Controls.Add(this.lblEmail);
            this.gbDetails.Controls.Add(this.txtEmail);
            this.gbDetails.Controls.Add(this.lblPwd);
            this.gbDetails.Controls.Add(this.txtPassword);
            this.gbDetails.Controls.Add(this.lblPwdHint);
            this.gbDetails.Controls.Add(this.lblRole);
            this.gbDetails.Controls.Add(this.cboRole);
            this.gbDetails.Controls.Add(this.btnNew);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Controls.Add(this.btnToggle);
            this.gbDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbDetails.Location = new System.Drawing.Point(20, 368);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(950, 212);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.Text = "Account details";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(15, 183);
            this.lblMode.Name = "lblMode";
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "New user";
            // 
            // lblFull
            // 
            this.lblFull.AutoSize = true;
            this.lblFull.Location = new System.Drawing.Point(15, 33);
            this.lblFull.Name = "lblFull";
            this.lblFull.TabIndex = 1;
            this.lblFull.Text = "Full name *";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(140, 29);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(240, 27);
            this.txtFullName.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(15, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username *";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 27);
            this.txtUsername.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(430, 33);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(540, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPwdHint
            // 
            this.lblPwdHint.AutoSize = true;
            this.lblPwdHint.Location = new System.Drawing.Point(540, 60);
            this.lblPwdHint.Name = "lblPwdHint";
            this.lblPwdHint.TabIndex = 9;
            this.lblPwdHint.Text = "Leave blank to keep the current password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(430, 109);
            this.lblRole.Name = "lblRole";
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role *";
            // 
            // cboRole
            // 
            this.cboRole.Location = new System.Drawing.Point(540, 105);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(240, 28);
            this.cboRole.TabIndex = 11;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 145);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 34);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save user";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(255, 145);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(140, 34);
            this.btnToggle.TabIndex = 14;
            this.btnToggle.Text = "Deactivate";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // UsersView
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbDetails);
            this.Name = "UsersView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPwdHint;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnToggle;
    }
}
