namespace VehicleMaintenanceSystem.Views
{
    partial class HistoryView
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
            this.lblVehicle = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Maintenance and repair records in date order, with total expenses for the period.";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(20, 58);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.TabIndex = 1;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // cboVehicle
            // 
            this.cboVehicle.Location = new System.Drawing.Point(85, 54);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(330, 28);
            this.cboVehicle.TabIndex = 2;
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(435, 58);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(480, 54);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 27);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.ShowCheckBox = true;
            this.dtpFrom.Checked = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(615, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(645, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 27);
            this.dtpTo.TabIndex = 6;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.ShowCheckBox = true;
            this.dtpTo.Checked = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(785, 51);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(90, 32);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv.Location = new System.Drawing.Point(20, 92);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(950, 290);
            this.dgv.TabIndex = 8;
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
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 394);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total maintenance expenses: 0 RWF";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtDetails);
            this.gbDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gbDetails.Location = new System.Drawing.Point(20, 424);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(950, 156);
            this.gbDetails.TabIndex = 10;
            this.gbDetails.Text = "Selected record details";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDetails.Location = new System.Drawing.Point(12, 26);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(926, 120);
            this.txtDetails.TabIndex = 0;
            this.txtDetails.Multiline = true;
            this.txtDetails.ReadOnly = true;
            // 
            // HistoryView
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbDetails);
            this.Name = "HistoryView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtDetails;
    }
}
