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
    public partial class CusBookTicket : Form
    {
        ParkingSpaceDb space;
        Customer customer;
        qlycarparkingDataContext db;
        public CusBookTicket(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void CusBookTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet12.ParkingSpaceDb' table. You can move, or remove it, as needed.
            this.parkingSpaceDbTableAdapter.Fill(this.userDataDataSet12.ParkingSpaceDb);
            space = new ParkingSpaceDb();
            db = new qlycarparkingDataContext();
            var list = (from s in db.ParkingSpaceDbs where s.Status=="Empty" select s).ToList();
            dataGridView1.DataSource = list;       
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void Parkbutton_Click(object sender, EventArgs e)
        {
            bool checkid = false;
            
           for (int i = 0; i < dataGridView1.Rows.Count; i++)
           {
                if (IDParktextBox.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {

                     checkid = true;
                     break;

                }
            }
            

            bool checkarea = false;
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    if (ParkAreatextBox.Text == dataGridView1.Rows[i].Cells[1].Value.ToString()) ;
                    {
                        checkarea = true;
                        break;
                    }
                }
            if (checkid && checkarea)
            {
                Car car = new Car(IDCartextBox.Text, customer.Id, CarBrandtextBox.Text, CarColortextBox.Text, int.Parse(IDParktextBox.Text));
                customer.Park(car, int.Parse(IDParktextBox.Text), dateTimePicker1.Value.Date);
                CusBookTicket_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fill again ID or Area");
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ParkAreatextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.Area.Contains(ParkAreatextBox.Text) && s.Status == "Empty"
                        select s).ToList();
            IDParktextBox.DataBindings.Clear();
            dataGridView1.DataSource = list;
        }

        private void IDParktextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.ID.ToString().Contains(IDParktextBox.Text) && s.Status == "Empty"
                        select s).ToList();
            ParkAreatextBox.DataBindings.Clear();
            ParkAreatextBox.DataBindings.Add("text", list, "Area");
            dataGridView1.DataSource = list;
        }
    }
}
