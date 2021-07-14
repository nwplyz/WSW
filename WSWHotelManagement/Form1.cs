using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WSWHotelManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Image.FromFile("logo_large.png");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (WSWsecurity.hashPassword(tbPassword.Text) == "86f7e437faa5a7fce15d1ddcb9eaeaea377667b8" && tbUsername.Text == "a")
            {
                MessageBox.Show("done");
            }
            else {
                MessageBox.Show("not done");
            }

           

        }
    }
}
