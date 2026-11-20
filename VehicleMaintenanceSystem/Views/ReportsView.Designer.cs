namespace VehicleMaintenanceSystem.Views
{
    partial class ReportsView
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
            this.lblReport = new System.Windows.Forms.Label();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Generate reports by vehicle and date range, then export them to CSV.";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(20, 58);
            this.lblReport.Name = "lblReport";
            this.lblReport.TabIndex = 1;
            this.lblReport.Text = "Report:";
            // 
            // cboReport
            // 
            this.cboReport.Location = new System.Drawing.Point(80, 54);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(280, 28);
            this.cboReport.TabIndex = 2;
            this.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReport.FormattingEnabled = true;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(385, 58);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.TabIndex = 3;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // cboVehicle
            // 
            this.cboVehicle.Location = new System.Drawing.Point(445, 54);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(320, 28);
            this.cboVehicle.TabIndex = 4;
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(20, 100);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(65, 96);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(125, 27);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Checked = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(210, 100);
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(240, 96);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(125, 27);
            this.dtpTo.TabIndex = 8;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Checked = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(385, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 34);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(535, 93);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(130, 34);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv.Location = new System.Drawing.Point(20, 140);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(950, 400);
            this.dgv.TabIndex = 11;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ReadOnly = true;
            this.dgv.MultiSelect = false;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(20, 552);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.TabIndex = 12;
            this.lblSummary.Text = "Choose a report and press Generate.";
            // 
            // ReportsView
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.cboReport);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblSummary);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblSummary;
    }
}
