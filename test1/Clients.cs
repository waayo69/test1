using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Clients: Form
    {
        private static readonly string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static readonly string ApplicationName = "Google Sheets Integration";
        private static readonly string SpreadsheetId = "1dCshOpmc9WO-WQR6XV264NgWiOkJR42ZSRYoBocj7sw"; // Replace with your Google Sheets ID
        private static readonly string SheetName = "Clients"; // Sheet name should match your database table
        public Clients()
        {
            InitializeComponent();
        }

        //private void FetchAndSyncGoogleSheetsData()
        //{
        //    try
        //    {
        //        // Load Google Sheets credentials
        //        UserCredential credential;
        //        using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
        //        {
        //            string credPath = "token.json";
        //            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //                GoogleClientSecrets.FromStream(stream).Secrets, // Updated to FromStream
        //                Scopes,
        //                "user",
        //                CancellationToken.None,
        //                new FileDataStore(credPath, true)).Result;
        //        }

        //        // Create the Sheets API service
        //        var service = new SheetsService(new BaseClientService.Initializer()
        //        {
        //            HttpClientInitializer = credential,
        //            ApplicationName = ApplicationName,
        //        });

        //        // Define the range of data to fetch
        //        var range = $"{SheetName}!A2:G1000"; // Adjust range as per your data
        //        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        //        // Execute the request and fetch data
        //        var response = request.Execute();
        //        var values = response.Values;


        //        if (values != null && values.Count > 0)
        //        {
        //            fetchedRows.Clear(); // Clear previous rows
        //            foreach (var row in values)
        //            {
        //                UpdateDatabase(row);
        //                this.clientsTableAdapter.Fill(this.waayo69.Clients);
        //                //this.clientsTableAdapter1.Fill(this.dbqueueDataSet3.Clients);

        //            }
        //            lblMessage.Text = $"Data synchronized successfully from Google Sheets!";
        //            //MessageBox.Show("Data synchronized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            lblMessage.Text = "No data found in Google Sheets.";
        //            //MessageBox.Show("No data found in Google Sheets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMessage.Text = $"Error fetching Google Sheets data: {ex.Message}";
        //        //MessageBox.Show($"Error fetching Google Sheets data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
