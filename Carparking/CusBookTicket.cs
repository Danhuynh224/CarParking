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
            // TODO: This line of code loads data into the 'userDataDataSet4.ParkingSpaceDb' table. You can move, or remove it, as needed.
            this.parkingSpaceDbTableAdapter.Fill(this.userDataDataSet4.ParkingSpaceDb);
            space = new ParkingSpaceDb();
            db = new qlycarparkingDataContext();
            var list = (from s in db.ParkingSpaceDbs where s.Status=="Empty" select s).ToList();
            dataGridView1.DataSource = list;
            
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void Parkbutton_Click(object sender, EventArgs e)
        {
            Car car = new Car(IDCartextBox.Text, customer.Id, CarBrandtextBox.Text, CarColortextBox.Text, int.Parse(IDParktextBox.Text));
            customer.Park(car, int.Parse(IDParktextBox.Text), dateTimePicker1.Value.Date);

        }
    }
}
