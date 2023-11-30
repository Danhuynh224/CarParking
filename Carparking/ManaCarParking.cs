using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carparking
{
    public partial class ManaCarParking : Form
    {
        ParkingSpaceDb space;
        qlycarparkingDataContext db;
        Manager manager;
        public ManaCarParking(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void ManaCarParking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet13.ParkingSpaceDb' table. You can move, or remove it, as needed.
            this.parkingSpaceDbTableAdapter.Fill(this.userDataDataSet13.ParkingSpaceDb);
          
            
            space =new ParkingSpaceDb();
            db = new qlycarparkingDataContext();
            var list = (from s in db.ParkingSpaceDbs select s).ToList();
            dataGridView1.DataSource = list;
            
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ParkingSpace carspace = new ParkingSpace(Int32.Parse(IDtextBox.Text), "Empty", float.Parse(PricetextBox.Text),
                "", AreatextBox.Text, 0);
                manager.AddCarParking(carspace);
                ManaCarParking_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot add an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PricetextBox.Text == "")
                    PricetextBox.Text="0";
                ParkingSpace carspace = new ParkingSpace(Int32.Parse(IDtextBox.Text), "Empty", float.Parse(PricetextBox.Text),
                "", AreatextBox.Text, 0);
                if (PricetextBox.Text == "0")
                    PricetextBox.Text = "";
                manager.EditCarParking(carspace);
                ManaCarParking_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot edit an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                manager.DeleteCarParking(Int32.Parse(IDtextBox.Text));
                ManaCarParking_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot delete an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IDsearchtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.ID.ToString().Contains(IDsearchtextBox.Text)
                        select s).ToList();
            IDtextBox.DataBindings.Clear();
            AreatextBox.DataBindings.Clear();
            PricetextBox.DataBindings.Clear();
            IDtextBox.DataBindings.Add("text", list, "ID");
            AreatextBox.DataBindings.Add("text", list, "Area");
            PricetextBox.DataBindings.Add("text", list, "Price");
            dataGridView1.DataSource= list;
        }

        private void AreaSearchtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.Area.Contains(AreaSearchtextBox.Text)
                        select s).ToList();
            IDtextBox.DataBindings.Clear();
            AreatextBox.DataBindings.Clear();
            PricetextBox.DataBindings.Clear();
            IDtextBox.DataBindings.Add("text", list, "ID");
            AreatextBox.DataBindings.Add("text", list, "Area");
            PricetextBox.DataBindings.Add("text", list, "Price");
            dataGridView1.DataSource = list;
        }

        private void savetofilespace_button_Click(object sender, EventArgs e)
        {
            //string path = "ParkingSpace.txt";

            //TextWriter wrt = new StreamWriter(path, true);
            //dataGridView1.AllowUserToAddRows = false;
            //wrt.WriteLine("   ID\t\t  Status\tPrice\t\tIDCar \t\tArea \t\tParkedDay");
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        wrt.Write("|" + "\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //    wrt.WriteLine("");
            //    wrt.WriteLine("================================================");
            //}
            //wrt.Close();
        }
    }
}
