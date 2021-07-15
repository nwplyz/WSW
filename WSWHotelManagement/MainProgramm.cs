using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSWHotelManagement
{
    public partial class MainProgramm : Form
    {
        public MainProgramm(string username)
        {
            string userName = username;
            InitializeComponent();
            lblUser.Text = userName;
            pbSettings.Visible = false;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = false;
            pbEmployee.Visible = false;
        }

        private void MainProgramm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = true;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = false;
            pbEmployee.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = false;
            pbCheckIn.Visible = true;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = false;
            pbEmployee.Visible = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = false;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = true;
            pbCustomer.Visible = false;
            pbEmployee.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = false;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = true;
            pbEmployee.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = false;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = false;
            pbEmployee.Visible = true;
        }
    }
}
