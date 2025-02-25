using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panelBase.Controls.Count > 0)
                this.panelBase.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelBase.Controls.Add(f);
            this.panelBase.Tag = f;
            f.Show();
        }

        private void btnExTrack_Click(object sender, EventArgs e)
        {
            loadform(new Form1());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
