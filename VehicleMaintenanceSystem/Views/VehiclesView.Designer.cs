namespace VehicleMaintenanceSystem.Views
{
    partial class VehiclesView
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
            this.lblMode = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.nudMileage = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register vehicles, search by registration number or model, and update details.";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 54);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search (registration no. or model):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(245, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(615, 48);
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
            this.dgv.Size = new System.Drawing.Size(950, 262);
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
            this.gbDetails.Controls.Add(this.lblMode);
            this.gbDetails.Controls.Add(this.lblReg);
            this.gbDetails.Controls.Add(this.txtReg);
            this.gbDetails.Controls.Add(this.lblMake);
            this.gbDetails.Controls.Add(this.txtMake);
            this.gbDetails.Controls.Add(this.lblModel);
            this.gbDetails.Controls.Add(this.txtModel);
            this.gbDetails.Controls.Add(this.lblYear);
            this.gbDetails.Controls.Add(this.nudYear);
            this.gbDetails.Controls.Add(this.lblType);
            this.gbDetails.Controls.Add(this.cboType);
            this.gbDetails.Controls.Add(this.lblMileage);
            this.gbDetails.Controls.Add(this.nudMileage);
            this.gbDetails.Controls.Add(this.btnNew);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbDetails.Location = new System.Drawing.Point(20, 362);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(950, 218);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.Text = "Vehicle details";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(15, 190);
            this.lblMode.Name = "lblMode";
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "New vehicle";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(15, 33);
            this.lblReg.Name = "lblReg";
            this.lblReg.TabIndex = 1;
            this.lblReg.Text = "Registration no. *";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(150, 29);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(230, 27);
            this.txtReg.TabIndex = 2;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(15, 71);
            this.lblMake.Name = "lblMake";
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make *";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(150, 67);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(230, 27);
            this.txtMake.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 109);
            this.lblModel.Name = "lblModel";
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model *";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(150, 105);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(230, 27);
            this.txtModel.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(430, 33);
            this.lblYear.Name = "lblYear";
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year *";
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(590, 29);
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(130, 27);
            this.nudYear.TabIndex = 8;
            this.nudYear.DecimalPlaces = 0;
            this.nudYear.Minimum = new decimal(new int[] {1950, 0, 0, 0});
            this.nudYear.Maximum = new decimal(new int[] {2100, 0, 0, 0});
            this.nudYear.Value = new decimal(new int[] {2020, 0, 0, 0});
            this.nudYear.ThousandsSeparator = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(430, 71);
            this.lblType.Name = "lblType";
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Vehicle type *";
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(590, 67);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(200, 28);
            this.cboType.TabIndex = 10;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(430, 109);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.TabIndex = 11;
            this.lblMileage.Text = "Current mileage (km) *";
            // 
            // nudMileage
            // 
            this.nudMileage.Location = new System.Drawing.Point(590, 105);
            this.nudMileage.Name = "nudMileage";
            this.nudMileage.Size = new System.Drawing.Size(160, 27);
            this.nudMileage.TabIndex = 12;
            this.nudMileage.DecimalPlaces = 0;
            this.nudMileage.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudMileage.Maximum = new decimal(new int[] {9999999, 0, 0, 0});
            this.nudMileage.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudMileage.ThousandsSeparator = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 146);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 34);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 34);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save vehicle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // VehiclesView
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbDetails);
            this.Name = "VehiclesView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMileage)).EndInit();
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
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.NumericUpDown nudMileage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
    }
}
