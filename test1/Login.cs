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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=waayo69_Clients;User ID=waayo69_Clients;Password=kris123asd;Encrypt=False; Connection Timeout=30");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + txtUser.Text + "' and Upassword='" + txtPass.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenu home = new MainMenu();
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Worng UserName or Password");
            Con.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(DialogResult== DialogResult.Yes)
                {
                    Application.Exit();
                }
                    
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
