namespace VehicleMaintenanceSystem.Views
{
    partial class DriversView
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAssign = new System.Windows.Forms.GroupBox();
            this.lblSel = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblVeh = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register drivers and assign them to vehicles.";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search (name or licence no.):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(210, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(580, 48);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(90, 30);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv.Location = new System.Drawing.Point(20, 88);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(950, 218);
            this.dgv.TabIndex = 5;
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
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.txtName);
            this.gbDetails.Controls.Add(this.lblPhone);
            this.gbDetails.Controls.Add(this.txtPhone);
            this.gbDetails.Controls.Add(this.lblEmail);
            this.gbDetails.Controls.Add(this.txtEmail);
            this.gbDetails.Controls.Add(this.lblLicence);
            this.gbDetails.Controls.Add(this.txtLicence);
            this.gbDetails.Controls.Add(this.lblCategory);
            this.gbDetails.Controls.Add(this.cboCategory);
            this.gbDetails.Controls.Add(this.lblExpiry);
            this.gbDetails.Controls.Add(this.dtpExpiry);
            this.gbDetails.Controls.Add(this.btnNew);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbDetails.Location = new System.Drawing.Point(20, 316);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(950, 172);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.Text = "Driver details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 33);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full name *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 71);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone *";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(420, 33);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.TabIndex = 6;
            this.lblLicence.Text = "Licence no. *";
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(560, 29);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(200, 27);
            this.txtLicence.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(420, 71);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Licence category *";
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(560, 67);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(120, 28);
            this.cboCategory.TabIndex = 9;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(420, 109);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.TabIndex = 10;
            this.lblExpiry.Text = "Licence expiry *";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(560, 105);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(140, 27);
            this.dtpExpiry.TabIndex = 11;
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(800, 40);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 34);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(800, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save driver";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbAssign
            // 
            this.gbAssign.Controls.Add(this.lblSel);
            this.gbAssign.Controls.Add(this.lblDriverName);
            this.gbAssign.Controls.Add(this.lblVeh);
            this.gbAssign.Controls.Add(this.cboVehicle);
            this.gbAssign.Controls.Add(this.btnAssign);
            this.gbAssign.Controls.Add(this.btnUnassign);
            this.gbAssign.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbAssign.Location = new System.Drawing.Point(20, 498);
            this.gbAssign.Name = "gbAssign";
            this.gbAssign.Size = new System.Drawing.Size(950, 84);
            this.gbAssign.TabIndex = 7;
            this.gbAssign.Text = "Assign driver to vehicle";
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Location = new System.Drawing.Point(15, 35);
            this.lblSel.Name = "lblSel";
            this.lblSel.TabIndex = 0;
            this.lblSel.Text = "Selected driver:";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(125, 35);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.TabIndex = 1;
            this.lblDriverName.Text = "(select a driver in the table)";
            // 
            // lblVeh
            // 
            this.lblVeh.AutoSize = true;
            this.lblVeh.Location = new System.Drawing.Point(430, 35);
            this.lblVeh.Name = "lblVeh";
            this.lblVeh.TabIndex = 2;
            this.lblVeh.Text = "Vehicle:";
            // 
            // cboVehicle
            // 
            this.cboVehicle.Location = new System.Drawing.Point(490, 31);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(200, 28);
            this.cboVehicle.TabIndex = 3;
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(700, 28);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(100, 32);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(808, 28);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(100, 32);
            this.btnUnassign.TabIndex = 5;
            this.btnUnassign.Text = "Remove";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // DriversView
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbAssign);
            this.Name = "DriversView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbAssign;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblVeh;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassign;
    }
}
