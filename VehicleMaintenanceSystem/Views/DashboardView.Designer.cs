namespace VehicleMaintenanceSystem.Views
{
    partial class DashboardView
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlVehicles = new System.Windows.Forms.Panel();
            this.lblVehiclesValue = new System.Windows.Forms.Label();
            this.lblVehiclesCaption = new System.Windows.Forms.Label();
            this.pnlUpcoming = new System.Windows.Forms.Panel();
            this.lblUpcomingValue = new System.Windows.Forms.Label();
            this.lblUpcomingCaption = new System.Windows.Forms.Label();
            this.pnlOverdue = new System.Windows.Forms.Panel();
            this.lblOverdueValue = new System.Windows.Forms.Label();
            this.lblOverdueCaption = new System.Windows.Forms.Label();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.lblCostValue = new System.Windows.Forms.Label();
            this.lblCostCaption = new System.Windows.Forms.Label();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.dgvAlerts = new System.Windows.Forms.DataGridView();
            this.lblRecent = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(20, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // pnlVehicles
            // 
            this.pnlVehicles.Controls.Add(this.lblVehiclesValue);
            this.pnlVehicles.Controls.Add(this.lblVehiclesCaption);
            this.pnlVehicles.Location = new System.Drawing.Point(20, 50);
            this.pnlVehicles.Name = "pnlVehicles";
            this.pnlVehicles.Size = new System.Drawing.Size(226, 80);
            this.pnlVehicles.TabIndex = 1;
            this.pnlVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblVehiclesValue
            // 
            this.lblVehiclesValue.AutoSize = true;
            this.lblVehiclesValue.Location = new System.Drawing.Point(12, 8);
            this.lblVehiclesValue.Name = "lblVehiclesValue";
            this.lblVehiclesValue.TabIndex = 0;
            this.lblVehiclesValue.Text = "0";
            this.lblVehiclesValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblVehiclesCaption
            // 
            this.lblVehiclesCaption.AutoSize = true;
            this.lblVehiclesCaption.Location = new System.Drawing.Point(14, 50);
            this.lblVehiclesCaption.Name = "lblVehiclesCaption";
            this.lblVehiclesCaption.TabIndex = 1;
            this.lblVehiclesCaption.Text = "Registered vehicles";
            // 
            // pnlUpcoming
            // 
            this.pnlUpcoming.Controls.Add(this.lblUpcomingValue);
            this.pnlUpcoming.Controls.Add(this.lblUpcomingCaption);
            this.pnlUpcoming.Location = new System.Drawing.Point(258, 50);
            this.pnlUpcoming.Name = "pnlUpcoming";
            this.pnlUpcoming.Size = new System.Drawing.Size(226, 80);
            this.pnlUpcoming.TabIndex = 2;
            this.pnlUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblUpcomingValue
            // 
            this.lblUpcomingValue.AutoSize = true;
            this.lblUpcomingValue.Location = new System.Drawing.Point(12, 8);
            this.lblUpcomingValue.Name = "lblUpcomingValue";
            this.lblUpcomingValue.TabIndex = 0;
            this.lblUpcomingValue.Text = "0";
            this.lblUpcomingValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblUpcomingCaption
            // 
            this.lblUpcomingCaption.AutoSize = true;
            this.lblUpcomingCaption.Location = new System.Drawing.Point(14, 50);
            this.lblUpcomingCaption.Name = "lblUpcomingCaption";
            this.lblUpcomingCaption.TabIndex = 1;
            this.lblUpcomingCaption.Text = "Upcoming services";
            // 
            // pnlOverdue
            // 
            this.pnlOverdue.Controls.Add(this.lblOverdueValue);
            this.pnlOverdue.Controls.Add(this.lblOverdueCaption);
            this.pnlOverdue.Location = new System.Drawing.Point(496, 50);
            this.pnlOverdue.Name = "pnlOverdue";
            this.pnlOverdue.Size = new System.Drawing.Size(226, 80);
            this.pnlOverdue.TabIndex = 3;
            this.pnlOverdue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblOverdueValue
            // 
            this.lblOverdueValue.AutoSize = true;
            this.lblOverdueValue.Location = new System.Drawing.Point(12, 8);
            this.lblOverdueValue.Name = "lblOverdueValue";
            this.lblOverdueValue.TabIndex = 0;
            this.lblOverdueValue.Text = "0";
            this.lblOverdueValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblOverdueCaption
            // 
            this.lblOverdueCaption.AutoSize = true;
            this.lblOverdueCaption.Location = new System.Drawing.Point(14, 50);
            this.lblOverdueCaption.Name = "lblOverdueCaption";
            this.lblOverdueCaption.TabIndex = 1;
            this.lblOverdueCaption.Text = "Overdue services";
            // 
            // pnlCost
            // 
            this.pnlCost.Controls.Add(this.lblCostValue);
            this.pnlCost.Controls.Add(this.lblCostCaption);
            this.pnlCost.Location = new System.Drawing.Point(734, 50);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(226, 80);
            this.pnlCost.TabIndex = 4;
            this.pnlCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblCostValue
            // 
            this.lblCostValue.AutoSize = true;
            this.lblCostValue.Location = new System.Drawing.Point(12, 8);
            this.lblCostValue.Name = "lblCostValue";
            this.lblCostValue.TabIndex = 0;
            this.lblCostValue.Text = "0";
            this.lblCostValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // lblCostCaption
            // 
            this.lblCostCaption.AutoSize = true;
            this.lblCostCaption.Location = new System.Drawing.Point(14, 50);
            this.lblCostCaption.Name = "lblCostCaption";
            this.lblCostCaption.TabIndex = 1;
            this.lblCostCaption.Text = "Maintenance cost this year (RWF)";
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.Location = new System.Drawing.Point(20, 150);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.TabIndex = 5;
            this.lblAlerts.Text = "Maintenance due alerts";
            // 
            // dgvAlerts
            // 
            this.dgvAlerts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvAlerts.Location = new System.Drawing.Point(20, 172);
            this.dgvAlerts.Name = "dgvAlerts";
            this.dgvAlerts.Size = new System.Drawing.Size(950, 170);
            this.dgvAlerts.TabIndex = 6;
            this.dgvAlerts.AllowUserToAddRows = false;
            this.dgvAlerts.AllowUserToDeleteRows = false;
            this.dgvAlerts.AllowUserToResizeRows = false;
            this.dgvAlerts.ReadOnly = true;
            this.dgvAlerts.MultiSelect = false;
            this.dgvAlerts.RowHeadersVisible = false;
            this.dgvAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlerts.BackgroundColor = System.Drawing.SystemColors.Window;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Location = new System.Drawing.Point(20, 356);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.TabIndex = 7;
            this.lblRecent.Text = "Recent maintenance activities";
            // 
            // dgvRecent
            // 
            this.dgvRecent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvRecent.Location = new System.Drawing.Point(20, 378);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.Size = new System.Drawing.Size(950, 200);
            this.dgvRecent.TabIndex = 8;
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.SystemColors.Window;
            // 
            // DashboardView
            // 
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlVehicles);
            this.Controls.Add(this.pnlUpcoming);
            this.Controls.Add(this.pnlOverdue);
            this.Controls.Add(this.pnlCost);
            this.Controls.Add(this.lblAlerts);
            this.Controls.Add(this.dgvAlerts);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.dgvRecent);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(990, 600);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlerts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlVehicles;
        private System.Windows.Forms.Label lblVehiclesValue;
        private System.Windows.Forms.Label lblVehiclesCaption;
        private System.Windows.Forms.Panel pnlUpcoming;
        private System.Windows.Forms.Label lblUpcomingValue;
        private System.Windows.Forms.Label lblUpcomingCaption;
        private System.Windows.Forms.Panel pnlOverdue;
        private System.Windows.Forms.Label lblOverdueValue;
        private System.Windows.Forms.Label lblOverdueCaption;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Label lblCostValue;
        private System.Windows.Forms.Label lblCostCaption;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.DataGridView dgvAlerts;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}
