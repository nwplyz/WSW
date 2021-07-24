using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSW_InventoryManagement
{
    public partial class frmMainProgram : Form
    {
        public frmMainProgram(string username)
        {
            string userName = username;
            InitializeComponent();
            lblUser.Text = userName;
            pbSettings.Visible = false;
            pbCheckIn.Visible = false;
            pbCheckOut.Visible = false;
            pbCustomer.Visible = false;
            pbEmployee.Visible = false;
            pbRooms.Visible = false;

        }
        string currentForm = "";
        private void MainProgramm_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "CheckIn")
            {
                currentForm = "CheckIn";
                pbSettings.Visible = false;
                pbCheckIn.Visible = true;
                pbCheckOut.Visible = false;
                pbCustomer.Visible = false;
                pbEmployee.Visible = false;
                pbRooms.Visible = false;
                /*
                frmCheckIn frmCheckIn_Vrb = new frmCheckIn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmCheckIn_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlLoadForm.Controls.Clear();
                this.pnlLoadForm.Controls.Add(frmCheckIn_Vrb);
                frmCheckIn_Vrb.Show();
                */
            }
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "CheckOut")
            {
                currentForm = "CheckOut";
                pbSettings.Visible = false;
                pbCheckIn.Visible = false;
                pbCheckOut.Visible = true;
                pbCustomer.Visible = false;
                pbEmployee.Visible = false;
                pbRooms.Visible = false;
                /* frmCheckOut frmCheckOut_Vrb = new frmCheckOut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmCheckOut_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlLoadForm.Controls.Clear();
                this.pnlLoadForm.Controls.Add(frmCheckOut_Vrb);
                frmCheckOut_Vrb.Show();
                */
            }
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "Customer")
            {
                currentForm = "Customer";
                pbSettings.Visible = false;
                pbCheckIn.Visible = false;
                pbCheckOut.Visible = false;
                pbCustomer.Visible = true;
                pbEmployee.Visible = false;
                pbRooms.Visible = false;
            }
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "Employee")
            {
                currentForm = "Employee";
                pbSettings.Visible = false;
                pbCheckIn.Visible = false;
                pbCheckOut.Visible = false;
                pbCustomer.Visible = false;
                pbEmployee.Visible = true;
                pbRooms.Visible = false;

            }
        }

        private void btnRooms_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "Rooms")
            {
                currentForm = "Rooms";
                pbSettings.Visible = false;
                pbCheckIn.Visible = false;
                pbCheckOut.Visible = false;
                pbCustomer.Visible = false;
                pbEmployee.Visible = false;
                pbRooms.Visible = true;
                /*frmRooms frmRooms_Vrb = new frmRooms() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmRooms_Vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnlLoadForm.Controls.Clear();
                this.pnlLoadForm.Controls.Add(frmRooms_Vrb);
                frmRooms_Vrb.Show();
                */
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            if (currentForm != "Settings")
            {
                currentForm = "Settings";

                pbSettings.Visible = true;
                pbCheckIn.Visible = false;
                pbCheckOut.Visible = false;
                pbCustomer.Visible = false;
                pbEmployee.Visible = false;
                pbRooms.Visible = false;
            }
        }
    }
}
