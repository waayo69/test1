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
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace test1
{
    public partial class Form1: Form
    {
        private string connectionString = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=waayo69_Clients;User ID=waayo69_Clients;Password=kris123asd;Encrypt=False; Connection Timeout=30";
        private DashboardForm piste;
        public Form1()
        {
            InitializeComponent();
            LoadPayments();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            reminderTimer.Start();
           //ShowOnSecondMonitor();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Paid", "Overdue", "Postponed" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.ResetText();
        }

        private void ShowOnSecondMonitor()
        {
            if (Screen.AllScreens.Length > 1) // Check if there are multiple monitors
            {
                var secondMonitor = Screen.AllScreens[1]; // Get the second monitor
                if (piste == null || piste.IsDisposed)
                {
                    piste = new DashboardForm
                    {
                        StartPosition = FormStartPosition.Manual, // Position manually
                        Location = secondMonitor.WorkingArea.Location // Set location to the second monitor
                    };
                }
                piste.Show();
                piste.Location = new System.Drawing.Point(
                    secondMonitor.WorkingArea.X + 100, // Offset by 100 pixels
                    secondMonitor.WorkingArea.Y + 100
                );
            }
            else
            {
                MessageBox.Show("Only one monitor detected. Monitoring Window will open on the primary monitor.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (piste == null || piste.IsDisposed)
                {
                    piste = new DashboardForm();
                }
                piste.Show();
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            string paymentName = txtPaymentName.Text;
            double amount = Convert.ToDouble(txtAmount.Text);
            DateTime dueDate = dtpDueDate.Value;
            string status = cmbStatus.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Payments (PaymentName, Amount, DueDate, Status) VALUES (@name, @amount, @dueDate, @status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", paymentName);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.Parameters.AddWithValue("@status", status);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Payment Added!");
            LoadPayments();
        }
        private void LoadPayments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = chkShowArchived.Checked
                ? "SELECT * FROM Payments"
                : "SELECT * FROM Payments WHERE IsArchived = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPayments.DataSource = dt;
                dgvPayments1.DataSource = dt;
            }
        }

        private void btnLoadSelected_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPayments.SelectedRows[0];

                txtPaymentName.Text = row.Cells["PaymentName"].Value.ToString();
                txtAmount.Text = row.Cells["Amount"].Value.ToString();
                dtpDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a payment to load.");
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);
            string paymentName = txtPaymentName.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            DateTime dueDate = dtpDueDate.Value;
            string status = cmbStatus.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Payments SET PaymentName=@name, Amount=@amount, DueDate=@dueDate, Status=@status WHERE PaymentID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", paymentName);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", paymentID);

                conn.Open();
                 cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Payment updated successfully!");
            LoadPayments();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);

            var confirmResult = MessageBox.Show("Are you sure you want to delete this payment?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Payments WHERE PaymentID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", paymentID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Payment deleted successfully!");
                LoadPayments();
            }
        }
        private int GetReminderDays()
        {
            return (int)nudReminderDays.Value; // User sets reminder days (e.g., 3 days before due date)
        }

        private void btnCheckReminders_Click(object sender, EventArgs e)
        {
            int reminderDays = GetReminderDays();
            DateTime today = DateTime.Today;
            DateTime reminderDate = today.AddDays(reminderDays);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PaymentName, DueDate FROM Payments WHERE DueDate BETWEEN @today AND @reminderDate AND Status != 'Paid'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@today", today);
                cmd.Parameters.AddWithValue("@reminderDate", reminderDate);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string paymentName = reader["PaymentName"].ToString();
                    DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);

                    ShowReminder(paymentName, dueDate);
                }

                conn.Close();
            }
        }
        //private void ShowReminder(string paymentName, DateTime dueDate)
        //{
        //    MessageBox.Show($"Reminder: {paymentName} is due on {dueDate:MMMM dd, yyyy}.", "Payment Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        private void ShowReminder(string paymentName, DateTime dueDate)
        {
            notifyIcon1.BalloonTipTitle = "Payment Reminder";
            notifyIcon1.BalloonTipText = $"{paymentName} is due on {dueDate:MMMM dd, yyyy}.";
            notifyIcon1.ShowBalloonTip(500000); // Shows for 5 seconds
        }
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            btnCheckReminders.PerformClick();
        }

        private void btnArchivePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to archive.");
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);

            var confirmResult = MessageBox.Show("Archive this payment?", "Confirm Archive", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Payments SET IsArchived = 1 WHERE PaymentID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", paymentID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Payment archived.");
                LoadPayments();
            }
        }

        private void btnRestorePayment_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an archived payment to restore.");
                return;
            }

            int paymentID = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["PaymentID"].Value);

            var confirmResult = MessageBox.Show("Restore this archived payment?", "Confirm Restore", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Payments SET IsArchived = 0 WHERE PaymentID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", paymentID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Payment restored.");
                LoadPayments();
            }
        }

        private void chkShowArchived_CheckedChanged(object sender, EventArgs e)
        {
            LoadPayments(); // Reload payments based on checkbox state
        }

        private void nudReminderDays_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void ExportToExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Excel Files|*.xlsx", Title = "Save as Excel File" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Upcoming Payments");

                    // Add Headers
                    for (int i = 0; i < dgvPayments.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dgvPayments.Columns[i].HeaderText;
                    }

                    decimal totalPaid = 0;
                    int lastRow = 1;

                    // Add Data & Calculate Total Paid
                    for (int i = 0; i < dgvPayments.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvPayments.Columns.Count; j++)
                        {
                            var cellValue = dgvPayments.Rows[i].Cells[j].Value?.ToString();
                            worksheet.Cell(i + 2, j + 1).Value = cellValue;

                            // If status is "Paid" and column is Amount
                            if (dgvPayments.Columns[j].HeaderText == "Amount" &&
                                dgvPayments.Rows[i].Cells["Status"].Value?.ToString().ToLower() == "paid" &&
                                decimal.TryParse(cellValue, out decimal amount))
                            {
                                totalPaid += amount;
                            }
                        }
                        lastRow = i + 2;
                    }

                    // Add Total Paid at the bottom
                    worksheet.Cell(lastRow + 2, 1).Value = "Total Paid:";
                    worksheet.Cell(lastRow + 2, 2).Value = totalPaid;
                    worksheet.Range(lastRow + 2, 1, lastRow + 2, 2).Style.Font.Bold = true;

                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Excel export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PDF Files|*.pdf", Title = "Save as PDF File" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 20, 20);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    PdfPTable pdfTable = new PdfPTable(dgvPayments.Columns.Count)
                    {
                        WidthPercentage = 100
                    };

                    // Add Headers
                    foreach (DataGridViewColumn column in dgvPayments.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240)
                        };
                        pdfTable.AddCell(cell);
                    }

                    decimal totalPaid = 0;

                    // Add Rows & Calculate Total Paid
                    foreach (DataGridViewRow row in dgvPayments.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }

                        if (row.Cells["Status"].Value?.ToString().ToLower() == "paid" &&
                            decimal.TryParse(row.Cells["Amount"].Value?.ToString(), out decimal amount))
                        {
                            totalPaid += amount;
                        }
                    }

                    // Add to PDF
                    pdfDoc.Add(new Paragraph("Upcoming Payments Report") { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n"));
                    pdfDoc.Add(pdfTable);

                    // Add Total Paid Summary
                    pdfDoc.Add(new Paragraph($"\nTotal Paid: ₱{totalPaid:N2}") { Alignment = Element.ALIGN_RIGHT, Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12) });

                    pdfDoc.Close();
                    MessageBox.Show("PDF export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
