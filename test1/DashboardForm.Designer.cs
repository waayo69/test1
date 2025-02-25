namespace test1
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUpcomingPayments = new System.Windows.Forms.DataGridView();
            this.nudDaysAhead = new System.Windows.Forms.NumericUpDown();
            this.btnRefreshDashboard = new System.Windows.Forms.Button();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblPendingPayments = new System.Windows.Forms.Label();
            this.RefreshDashboard = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysAhead)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpcomingPayments
            // 
            this.dgvUpcomingPayments.AllowUserToAddRows = false;
            this.dgvUpcomingPayments.AllowUserToDeleteRows = false;
            this.dgvUpcomingPayments.AllowUserToResizeColumns = false;
            this.dgvUpcomingPayments.AllowUserToResizeRows = false;
            this.dgvUpcomingPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvUpcomingPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpcomingPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUpcomingPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUpcomingPayments.Location = new System.Drawing.Point(0, 0);
            this.dgvUpcomingPayments.Name = "dgvUpcomingPayments";
            this.dgvUpcomingPayments.RowHeadersWidth = 51;
            this.dgvUpcomingPayments.RowTemplate.Height = 24;
            this.dgvUpcomingPayments.Size = new System.Drawing.Size(800, 150);
            this.dgvUpcomingPayments.TabIndex = 0;
            // 
            // nudDaysAhead
            // 
            this.nudDaysAhead.Location = new System.Drawing.Point(461, 319);
            this.nudDaysAhead.Name = "nudDaysAhead";
            this.nudDaysAhead.Size = new System.Drawing.Size(120, 22);
            this.nudDaysAhead.TabIndex = 1;
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.Location = new System.Drawing.Point(461, 363);
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDashboard.TabIndex = 2;
            this.btnRefreshDashboard.Text = "Refresh";
            this.btnRefreshDashboard.UseVisualStyleBackColor = true;
            this.btnRefreshDashboard.Click += new System.EventHandler(this.btnRefreshDashboard_Click);
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Location = new System.Drawing.Point(57, 321);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(66, 16);
            this.lblTotalDue.TabIndex = 3;
            this.lblTotalDue.Text = "Total Due";
            // 
            // lblPendingPayments
            // 
            this.lblPendingPayments.AutoSize = true;
            this.lblPendingPayments.Location = new System.Drawing.Point(60, 370);
            this.lblPendingPayments.Name = "lblPendingPayments";
            this.lblPendingPayments.Size = new System.Drawing.Size(120, 16);
            this.lblPendingPayments.TabIndex = 4;
            this.lblPendingPayments.Text = "Pending Payments";
            // 
            // RefreshDashboard
            // 
            this.RefreshDashboard.Enabled = true;
            this.RefreshDashboard.Interval = 3600;
            this.RefreshDashboard.Tick += new System.EventHandler(this.RefreshDashboard_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPendingPayments);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.btnRefreshDashboard);
            this.Controls.Add(this.nudDaysAhead);
            this.Controls.Add(this.dgvUpcomingPayments);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysAhead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpcomingPayments;
        private System.Windows.Forms.NumericUpDown nudDaysAhead;
        private System.Windows.Forms.Button btnRefreshDashboard;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblPendingPayments;
        private System.Windows.Forms.Timer RefreshDashboard;
    }
}