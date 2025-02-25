using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class DashboardForm: Form
    {
        private string connectionString = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=waayo69_Clients;User ID=waayo69_Clients;Password=kris123asd;Encrypt=False; Connection Timeout=30";
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            nudDaysAhead.Value = 0; // Default to 7 days
            LoadUpcomingPayments();
        }
        private void LoadUpcomingPayments()
        {
            int daysAhead = (int)nudDaysAhead.Value;
            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(daysAhead);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT PaymentID, PaymentName, Amount, DueDate, Status
            FROM Payments
            WHERE DueDate BETWEEN @today AND @endDate AND Status != 'Paid' AND IsArchived = 0
            ORDER BY DueDate ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@today", today);
                da.SelectCommand.Parameters.AddWithValue("@endDate", endDate);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUpcomingPayments.DataSource = dt;

                UpdateDashboardSummary(dt);
                FormatDataGridView();
            }
        }
        private void UpdateDashboardSummary(DataTable dt)
        {
            decimal totalDue = dt.AsEnumerable().Sum(row => row.Field<decimal>("Amount"));
            int pendingCount = dt.Rows.Count;

            lblTotalDue.Text = $"Total Amount Due: ₱{totalDue:N2}";
            lblPendingPayments.Text = $"Pending Payments: {pendingCount}";
        }
        private void FormatDataGridView()
        {
            foreach (DataGridViewRow row in dgvUpcomingPayments.Rows)
            {
                DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                int daysUntilDue = (dueDate - DateTime.Today).Days;

                if (daysUntilDue < 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral; // Overdue
                }
                else if (daysUntilDue <= 3)
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow; // Almost due
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen; // Safe zone
                }
            }
        }

        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadUpcomingPayments();
        }

        private void RefreshDashboard_Tick(object sender, EventArgs e)
        {
            LoadUpcomingPayments();
        }
    }
}
