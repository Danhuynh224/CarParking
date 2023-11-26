using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ManaCarParking()
        {
            InitializeComponent();
        }

        private void ManaCarParking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet8.ParkingSpaceDb' table. You can move, or remove it, as needed.
            this.parkingSpaceDbTableAdapter.Fill(this.userDataDataSet8.ParkingSpaceDb);
            space =new ParkingSpaceDb();
            db = new qlycarparkingDataContext();
            var list = (from s in db.ParkingSpaceDbs select s).ToList();
            dataGridView1.DataSource = list;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                space.ID = Int32.Parse(IDtextBox.Text);
                space.Status = "Empty";
                space.Price = float.Parse(PricetextBox.Text);
                space.IDCar = "";
                space.Area = AreatextBox.Text;
                space.ParkedDays = 0;
                db.ParkingSpaceDbs.InsertOnSubmit(space);
                db.SubmitChanges();
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
                space = db.ParkingSpaceDbs.Where(s => s.ID == Int32.Parse(IDtextBox.Text)).Single();
                if(AreatextBox.Text!="")
                    space.Area= AreatextBox.Text;
                if(PricetextBox.Text!="")
                    space.Price =float.Parse(PricetextBox.Text);
                db.SubmitChanges();
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
                space = db.ParkingSpaceDbs.Where(s => s.ID == Int32.Parse(IDtextBox.Text)).Single();
                db.ParkingSpaceDbs.DeleteOnSubmit(space);
                db.SubmitChanges();
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
    }
}
