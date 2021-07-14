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

        }

        private void MainProgramm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pbSettings.Visible = true;
        }
    }
}
