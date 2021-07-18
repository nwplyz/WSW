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

namespace WSWHotelManagement
{
    public partial class frmCheckIn : Form
    {
        funDB fun = new funDB();
        string query;
        public frmCheckIn()
        {
            InitializeComponent();
        }


        public void setComboBox(string query, ComboBox comboBox)
        {
            SqlDataReader sqlDataReader = fun.getComboData(query);
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    comboBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
        }

        private void cbRoomNumber_Click(object sender, EventArgs e)
        {
            try
            {
                cbRoomNumber.Items.Clear();
                query = "select RoomNumber from rooms where Bed = " + int.Parse(cbBed.Text) + " and ExtraBeds >= " + int.Parse(cbExtraBed.Text) + "  and Available = 'Yes'";
                setComboBox(query, cbRoomNumber);
            }
            catch (Exception)
            {

                
            }
            
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (chbPassport.Checked)
            {

            }
            else
            {
                MessageBox.Show("Please check customers passport");
            }
        }
    }
}
