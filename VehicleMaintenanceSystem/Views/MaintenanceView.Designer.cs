namespace VehicleMaintenanceSystem.Views
{
    partial class MaintenanceView
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.gbSchedule = new System.Windows.Forms.GroupBox();
            this.lblSVehicle = new System.Windows.Forms.Label();
            this.cboSVehicle = new System.Windows.Forms.ComboBox();
            this.lblPlanned = new System.Windows.Forms.Label();
            this.dtpPlanned = new System.Windows.Forms.DateTimePicker();
            this.lblExpMileage = new System.Windows.Forms.Label();
            this.nudExpMileage = new System.Windows.Forms.NumericUpDown();
            this.lblSDesc = new System.Windows.Forms.Label();
            this.txtSDesc = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblLegend = new System.Windows.Forms.Label();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cboNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.tabRecord = new System.Windows.Forms.TabPage();
            this.gbRecord = new System.Windows.Forms.GroupBox();
            this.lblRVehicle = new System.Windows.Forms.Label();
            this.cboRVehicle = new System.Windows.Forms.ComboBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblRMileage = new System.Windows.Forms.Label();
            this.nudRMileage = new System.Windows.Forms.NumericUpDown();
            this.lblRType = new System.Windows.Forms.Label();
            this.cboRType = new System.Windows.Forms.ComboBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblRDesc = new System.Windows.Forms.Label();
            this.txtRDesc = new System.Windows.Forms.TextBox();
            this.lblLinked = new System.Windows.Forms.Label();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.btnClearRecord = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSchedule);
            this.tabs.Controls.Add(this.tabRecord);
            this.tabs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.tabs.Location = new System.Drawing.Point(10, 10);
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(970, 580);
            this.tabs.TabIndex = 0;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.gbSchedule);
            this.tabSchedule.Controls.Add(this.lblFilter);
            this.tabSchedule.Controls.Add(this.cboStatusFilter);
            this.tabSchedule.Controls.Add(this.lblLegend);
            this.tabSchedule.Controls.Add(this.dgvSchedules);
            this.tabSchedule.Controls.Add(this.lblNewStatus);
            this.tabSchedule.Controls.Add(this.cboNewStatus);
            this.tabSchedule.Controls.Add(this.btnUpdateStatus);
            this.tabSchedule.Location = new System.Drawing.Point(4, 26);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new System.Drawing.Size(962, 550);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Schedule and Status";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            // 
            // gbSchedule
            // 
            this.gbSchedule.Controls.Add(this.lblSVehicle);
            this.gbSchedule.Controls.Add(this.cboSVehicle);
            this.gbSchedule.Controls.Add(this.lblPlanned);
            this.gbSchedule.Controls.Add(this.dtpPlanned);
            this.gbSchedule.Controls.Add(this.lblExpMileage);
            this.gbSchedule.Controls.Add(this.nudExpMileage);
            this.gbSchedule.Controls.Add(this.lblSDesc);
            this.gbSchedule.Controls.Add(this.txtSDesc);
            this.gbSchedule.Controls.Add(this.btnSchedule);
            this.gbSchedule.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbSchedule.Location = new System.Drawing.Point(10, 10);
            this.gbSchedule.Name = "gbSchedule";
            this.gbSchedule.Size = new System.Drawing.Size(940, 122);
            this.gbSchedule.TabIndex = 0;
            this.gbSchedule.Text = "Schedule upcoming maintenance";
            // 
            // lblSVehicle
            // 
            this.lblSVehicle.AutoSize = true;
            this.lblSVehicle.Location = new System.Drawing.Point(15, 36);
            this.lblSVehicle.Name = "lblSVehicle";
            this.lblSVehicle.TabIndex = 0;
            this.lblSVehicle.Text = "Vehicle *";
            // 
            // cboSVehicle
            // 
            this.cboSVehicle.Location = new System.Drawing.Point(100, 32);
            this.cboSVehicle.Name = "cboSVehicle";
            this.cboSVehicle.Size = new System.Drawing.Size(330, 28);
            this.cboSVehicle.TabIndex = 1;
            this.cboSVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSVehicle.FormattingEnabled = true;
            // 
            // lblPlanned
            // 
            this.lblPlanned.AutoSize = true;
            this.lblPlanned.Location = new System.Drawing.Point(460, 36);
            this.lblPlanned.Name = "lblPlanned";
            this.lblPlanned.TabIndex = 2;
            this.lblPlanned.Text = "Planned date *";
            // 
            // dtpPlanned
            // 
            this.dtpPlanned.Location = new System.Drawing.Point(570, 32);
            this.dtpPlanned.Name = "dtpPlanned";
            this.dtpPlanned.Size = new System.Drawing.Size(140, 27);
            this.dtpPlanned.TabIndex = 3;
            this.dtpPlanned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblExpMileage
            // 
            this.lblExpMileage.AutoSize = true;
            this.lblExpMileage.Location = new System.Drawing.Point(15, 76);
            this.lblExpMileage.Name = "lblExpMileage";
            this.lblExpMileage.TabIndex = 4;
            this.lblExpMileage.Text = "Expected mileage *";
            // 
            // nudExpMileage
            // 
            this.nudExpMileage.Location = new System.Drawing.Point(150, 72);
            this.nudExpMileage.Name = "nudExpMileage";
            this.nudExpMileage.Size = new System.Drawing.Size(140, 27);
            this.nudExpMileage.TabIndex = 5;
            this.nudExpMileage.DecimalPlaces = 0;
            this.nudExpMileage.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudExpMileage.Maximum = new decimal(new int[] {9999999, 0, 0, 0});
            this.nudExpMileage.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudExpMileage.ThousandsSeparator = true;
            // 
            // lblSDesc
            // 
            this.lblSDesc.AutoSize = true;
            this.lblSDesc.Location = new System.Drawing.Point(320, 76);
            this.lblSDesc.Name = "lblSDesc";
            this.lblSDesc.TabIndex = 6;
            this.lblSDesc.Text = "Service description *";
            // 
            // txtSDesc
            // 
            this.txtSDesc.Location = new System.Drawing.Point(465, 72);
            this.txtSDesc.Name = "txtSDesc";
            this.txtSDesc.Size = new System.Drawing.Size(330, 27);
            this.txtSDesc.TabIndex = 7;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(810, 68);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(115, 34);
            this.btnSchedule.TabIndex = 8;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 148);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Show status:";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.Location = new System.Drawing.Point(100, 144);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(160, 28);
            this.cboStatusFilter.TabIndex = 2;
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.Location = new System.Drawing.Point(280, 148);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.TabIndex = 3;
            this.lblLegend.Text = "Alert: Overdue = date passed or mileage reached.  Upcoming = within 14 days or 500 km.";
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvSchedules.Location = new System.Drawing.Point(10, 178);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.Size = new System.Drawing.Size(940, 300);
            this.dgvSchedules.TabIndex = 4;
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.AllowUserToResizeRows = false;
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.MultiSelect = false;
            this.dgvSchedules.RowHeadersVisible = false;
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.BackgroundColor = System.Drawing.SystemColors.Window;
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(12, 497);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.TabIndex = 5;
            this.lblNewStatus.Text = "Change status of the selected item to:";
            // 
            // cboNewStatus
            // 
            this.cboNewStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.cboNewStatus.Location = new System.Drawing.Point(250, 492);
            this.cboNewStatus.Name = "cboNewStatus";
            this.cboNewStatus.Size = new System.Drawing.Size(160, 28);
            this.cboNewStatus.TabIndex = 6;
            this.cboNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewStatus.FormattingEnabled = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdateStatus.Location = new System.Drawing.Point(420, 489);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(130, 34);
            this.btnUpdateStatus.TabIndex = 7;
            this.btnUpdateStatus.Text = "Update status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // tabRecord
            // 
            this.tabRecord.Controls.Add(this.gbRecord);
            this.tabRecord.Controls.Add(this.lblTip);
            this.tabRecord.Location = new System.Drawing.Point(4, 26);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.Size = new System.Drawing.Size(962, 550);
            this.tabRecord.TabIndex = 1;
            this.tabRecord.Text = "Record Service";
            this.tabRecord.Padding = new System.Windows.Forms.Padding(3);
            // 
            // gbRecord
            // 
            this.gbRecord.Controls.Add(this.lblRVehicle);
            this.gbRecord.Controls.Add(this.cboRVehicle);
            this.gbRecord.Controls.Add(this.lblServiceDate);
            this.gbRecord.Controls.Add(this.dtpServiceDate);
            this.gbRecord.Controls.Add(this.lblRMileage);
            this.gbRecord.Controls.Add(this.nudRMileage);
            this.gbRecord.Controls.Add(this.lblRType);
            this.gbRecord.Controls.Add(this.cboRType);
            this.gbRecord.Controls.Add(this.lblProvider);
            this.gbRecord.Controls.Add(this.txtProvider);
            this.gbRecord.Controls.Add(this.lblCost);
            this.gbRecord.Controls.Add(this.nudCost);
            this.gbRecord.Controls.Add(this.lblRDesc);
            this.gbRecord.Controls.Add(this.txtRDesc);
            this.gbRecord.Controls.Add(this.lblLinked);
            this.gbRecord.Controls.Add(this.btnSaveRecord);
            this.gbRecord.Controls.Add(this.btnClearRecord);
            this.gbRecord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbRecord.Location = new System.Drawing.Point(10, 10);
            this.gbRecord.Name = "gbRecord";
            this.gbRecord.Size = new System.Drawing.Size(940, 330);
            this.gbRecord.TabIndex = 0;
            this.gbRecord.Text = "Record maintenance / repair performed";
            // 
            // lblRVehicle
            // 
            this.lblRVehicle.AutoSize = true;
            this.lblRVehicle.Location = new System.Drawing.Point(15, 36);
            this.lblRVehicle.Name = "lblRVehicle";
            this.lblRVehicle.TabIndex = 0;
            this.lblRVehicle.Text = "Vehicle *";
            // 
            // cboRVehicle
            // 
            this.cboRVehicle.Location = new System.Drawing.Point(160, 32);
            this.cboRVehicle.Name = "cboRVehicle";
            this.cboRVehicle.Size = new System.Drawing.Size(330, 28);
            this.cboRVehicle.TabIndex = 1;
            this.cboRVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRVehicle.FormattingEnabled = true;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(530, 36);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.TabIndex = 2;
            this.lblServiceDate.Text = "Service date *";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(650, 32);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(150, 27);
            this.dtpServiceDate.TabIndex = 3;
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblRMileage
            // 
            this.lblRMileage.AutoSize = true;
            this.lblRMileage.Location = new System.Drawing.Point(15, 76);
            this.lblRMileage.Name = "lblRMileage";
            this.lblRMileage.TabIndex = 4;
            this.lblRMileage.Text = "Mileage (km) *";
            // 
            // nudRMileage
            // 
            this.nudRMileage.Location = new System.Drawing.Point(160, 72);
            this.nudRMileage.Name = "nudRMileage";
            this.nudRMileage.Size = new System.Drawing.Size(150, 27);
            this.nudRMileage.TabIndex = 5;
            this.nudRMileage.DecimalPlaces = 0;
            this.nudRMileage.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudRMileage.Maximum = new decimal(new int[] {9999999, 0, 0, 0});
            this.nudRMileage.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudRMileage.ThousandsSeparator = true;
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Location = new System.Drawing.Point(530, 76);
            this.lblRType.Name = "lblRType";
            this.lblRType.TabIndex = 6;
            this.lblRType.Text = "Maintenance type *";
            // 
            // cboRType
            // 
            this.cboRType.Location = new System.Drawing.Point(650, 72);
            this.cboRType.Name = "cboRType";
            this.cboRType.Size = new System.Drawing.Size(200, 28);
            this.cboRType.TabIndex = 7;
            this.cboRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRType.FormattingEnabled = true;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(15, 116);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.TabIndex = 8;
            this.lblProvider.Text = "Service provider *";
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(160, 112);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(330, 27);
            this.txtProvider.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(530, 116);
            this.lblCost.Name = "lblCost";
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost (RWF) *";
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(650, 112);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(150, 27);
            this.nudCost.TabIndex = 11;
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudCost.Maximum = new decimal(new int[] {999999999, 0, 0, 0});
            this.nudCost.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudCost.ThousandsSeparator = true;
            // 
            // lblRDesc
            // 
            this.lblRDesc.AutoSize = true;
            this.lblRDesc.Location = new System.Drawing.Point(15, 156);
            this.lblRDesc.Name = "lblRDesc";
            this.lblRDesc.TabIndex = 12;
            this.lblRDesc.Text = "Work description *";
            // 
            // txtRDesc
            // 
            this.txtRDesc.Location = new System.Drawing.Point(160, 152);
            this.txtRDesc.Name = "txtRDesc";
            this.txtRDesc.Size = new System.Drawing.Size(690, 90);
            this.txtRDesc.TabIndex = 13;
            this.txtRDesc.Multiline = true;
            this.txtRDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lblLinked
            // 
            this.lblLinked.AutoSize = true;
            this.lblLinked.Location = new System.Drawing.Point(15, 256);
            this.lblLinked.Name = "lblLinked";
            this.lblLinked.TabIndex = 14;
            this.lblLinked.Text = "Linked schedule: none";
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Location = new System.Drawing.Point(160, 282);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(140, 34);
            this.btnSaveRecord.TabIndex = 15;
            this.btnSaveRecord.Text = "Save record";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // btnClearRecord
            // 
            this.btnClearRecord.Location = new System.Drawing.Point(310, 282);
            this.btnClearRecord.Name = "btnClearRecord";
            this.btnClearRecord.Size = new System.Drawing.Size(100, 34);
            this.btnClearRecord.TabIndex = 16;
            this.btnClearRecord.Text = "Clear";
            this.btnClearRecord.UseVisualStyleBackColor = true;
            this.btnClearRecord.Click += new System.EventHandler(this.btnClearRecord_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 352);
            this.lblTip.Name = "lblTip";
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Tip: marking a scheduled item as Completed (other tab) opens this form pre-filled.";
            // 
            // MaintenanceView
            // 
            this.Controls.Add(this.tabs);
            this.Name = "MaintenanceView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.nudExpMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.GroupBox gbSchedule;
        private System.Windows.Forms.Label lblSVehicle;
        private System.Windows.Forms.ComboBox cboSVehicle;
        private System.Windows.Forms.Label lblPlanned;
        private System.Windows.Forms.DateTimePicker dtpPlanned;
        private System.Windows.Forms.Label lblExpMileage;
        private System.Windows.Forms.NumericUpDown nudExpMileage;
        private System.Windows.Forms.Label lblSDesc;
        private System.Windows.Forms.TextBox txtSDesc;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cboNewStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.TabPage tabRecord;
        private System.Windows.Forms.GroupBox gbRecord;
        private System.Windows.Forms.Label lblRVehicle;
        private System.Windows.Forms.ComboBox cboRVehicle;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblRMileage;
        private System.Windows.Forms.NumericUpDown nudRMileage;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.ComboBox cboRType;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblRDesc;
        private System.Windows.Forms.TextBox txtRDesc;
        private System.Windows.Forms.Label lblLinked;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Button btnClearRecord;
        private System.Windows.Forms.Label lblTip;
    }
}
