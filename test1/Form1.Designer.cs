namespace test1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.btnCheckReminders = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.nudReminderDays = new System.Windows.Forms.NumericUpDown();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnLoadSelected = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.chkShowArchived = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvPayments1 = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderDays)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.HotTrack = true;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(897, 520);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Controls.Add(this.dgvPayments);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add new";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 333);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnMainMenu);
            this.tabPage4.Controls.Add(this.btnDeletePayment);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtPaymentName);
            this.tabPage4.Controls.Add(this.btnCheckReminders);
            this.tabPage4.Controls.Add(this.lblName);
            this.tabPage4.Controls.Add(this.nudReminderDays);
            this.tabPage4.Controls.Add(this.btnAddPayment);
            this.tabPage4.Controls.Add(this.btnLoadSelected);
            this.tabPage4.Controls.Add(this.btnUpdatePayment);
            this.tabPage4.Controls.Add(this.dtpDueDate);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtAmount);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.cmbStatus);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(875, 304);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Add New";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(764, 7);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(97, 23);
            this.btnMainMenu.TabIndex = 11;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.AutoSize = true;
            this.btnDeletePayment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePayment.Location = new System.Drawing.Point(547, 215);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(113, 41);
            this.btnDeletePayment.TabIndex = 7;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Remind in days";
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Location = new System.Drawing.Point(87, 92);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(245, 22);
            this.txtPaymentName.TabIndex = 0;
            // 
            // btnCheckReminders
            // 
            this.btnCheckReminders.AutoSize = true;
            this.btnCheckReminders.Location = new System.Drawing.Point(586, 147);
            this.btnCheckReminders.Name = "btnCheckReminders";
            this.btnCheckReminders.Size = new System.Drawing.Size(124, 26);
            this.btnCheckReminders.TabIndex = 9;
            this.btnCheckReminders.Text = "Check Reminders";
            this.btnCheckReminders.UseVisualStyleBackColor = true;
            this.btnCheckReminders.Click += new System.EventHandler(this.btnCheckReminders_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // nudReminderDays
            // 
            this.nudReminderDays.Location = new System.Drawing.Point(586, 93);
            this.nudReminderDays.Name = "nudReminderDays";
            this.nudReminderDays.Size = new System.Drawing.Size(120, 22);
            this.nudReminderDays.TabIndex = 8;
            this.nudReminderDays.ValueChanged += new System.EventHandler(this.nudReminderDays_ValueChanged);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.AutoSize = true;
            this.btnAddPayment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPayment.Location = new System.Drawing.Point(135, 215);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 41);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Submit";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnLoadSelected
            // 
            this.btnLoadSelected.AutoSize = true;
            this.btnLoadSelected.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLoadSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSelected.Location = new System.Drawing.Point(241, 215);
            this.btnLoadSelected.Name = "btnLoadSelected";
            this.btnLoadSelected.Size = new System.Drawing.Size(105, 41);
            this.btnLoadSelected.TabIndex = 5;
            this.btnLoadSelected.Text = "Load Selected";
            this.btnLoadSelected.UseVisualStyleBackColor = false;
            this.btnLoadSelected.Click += new System.EventHandler(this.btnLoadSelected_Click);
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.AutoSize = true;
            this.btnUpdatePayment.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePayment.Location = new System.Drawing.Point(389, 215);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(118, 41);
            this.btnUpdatePayment.TabIndex = 6;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = false;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(87, 151);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(245, 22);
            this.dtpDueDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(389, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(143, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(389, 147);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(143, 24);
            this.cmbStatus.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnExportToExcel);
            this.tabPage5.Controls.Add(this.btnExportToPDF);
            this.tabPage5.Controls.Add(this.chkShowArchived);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(875, 304);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Archiving";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(253, 193);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(101, 42);
            this.btnExportToExcel.TabIndex = 15;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Location = new System.Drawing.Point(97, 193);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(93, 42);
            this.btnExportToPDF.TabIndex = 14;
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // chkShowArchived
            // 
            this.chkShowArchived.AutoSize = true;
            this.chkShowArchived.Location = new System.Drawing.Point(97, 78);
            this.chkShowArchived.Name = "chkShowArchived";
            this.chkShowArchived.Size = new System.Drawing.Size(118, 20);
            this.chkShowArchived.TabIndex = 13;
            this.chkShowArchived.Text = "Show Archived";
            this.chkShowArchived.UseVisualStyleBackColor = true;
            this.chkShowArchived.CheckedChanged += new System.EventHandler(this.chkShowArchived_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRestorePayment_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Archive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnArchivePayment_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPayments.Location = new System.Drawing.Point(3, 3);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPayments.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(883, 149);
            this.dgvPayments.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvPayments1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(889, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payment Table";
            // 
            // dgvPayments1
            // 
            this.dgvPayments1.AllowUserToAddRows = false;
            this.dgvPayments1.AllowUserToDeleteRows = false;
            this.dgvPayments1.AllowUserToResizeColumns = false;
            this.dgvPayments1.AllowUserToResizeRows = false;
            this.dgvPayments1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayments1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayments1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPayments1.Location = new System.Drawing.Point(0, 0);
            this.dgvPayments1.Name = "dgvPayments1";
            this.dgvPayments1.ReadOnly = true;
            this.dgvPayments1.RowHeadersWidth = 51;
            this.dgvPayments1.RowTemplate.Height = 24;
            this.dgvPayments1.Size = new System.Drawing.Size(889, 150);
            this.dgvPayments1.TabIndex = 7;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // reminderTimer
            // 
            this.reminderTimer.Enabled = true;
            this.reminderTimer.Interval = 3600000;
            this.reminderTimer.Tick += new System.EventHandler(this.ReminderTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(897, 520);
            this.ControlBox = false;
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderDays)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPaymentName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadSelected;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.NumericUpDown nudReminderDays;
        private System.Windows.Forms.Button btnCheckReminders;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer reminderTimer;
        private System.Windows.Forms.DataGridView dgvPayments1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkShowArchived;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnMainMenu;
    }
}

