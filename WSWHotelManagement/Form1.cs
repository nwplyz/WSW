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
            if (WSWsecurity.hashPassword(tbPassword.Text) == "hvfkN/qlp/zhXR3cuerq6jd2Z7g=" && tbUsername.Text == "a")
            {
               
                MainProgramm mainProgramm = new MainProgramm(tbUsername.Text);
                this.Hide();
                mainProgramm.Show();
            }
            else {
                MessageBox.Show("username or password false");
            }          
        }
    }
}
