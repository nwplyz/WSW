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
    public partial class frmRooms : Form
    {
        funDB fn = new funDB();
        String query;

        public frmRooms()
        {
            InitializeComponent();
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet dataSet = fn.getData(query);
            DGVrooms.DataSource = dataSet.Tables[0];
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbDefaultPrice.Text != "" && tbRoomClass.Text != "" && tbRoomNumber.Text != "" && cbBed.Text != "" && cbExtraBed.Text != "")
            {
                string RoomNumber = tbRoomNumber.Text;               
                string RoomClass = tbRoomClass.Text;
                int Bed = int.Parse(cbBed.Text);
                int ExtraBed = int.Parse(cbExtraBed.Text);
                int Price = int.Parse(tbDefaultPrice.Text);

                query = "insert into rooms (RoomNumber,RoomClass,Bed,ExtraBeds,Price) values ('"+RoomNumber+"','"+RoomClass +"',"+Bed+","+ExtraBed+","+Price+")";
                fn.setData(query,"Room has been added");


                frmRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill Everything", "Warning");
            }
        }
    }
}
