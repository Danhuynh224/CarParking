using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Carparking
{
    public partial class CusRetrieve : Form
    {
        Customer customer;
        TicketDb tick;
        qlyticketDataContext db;
        public CusRetrieve(Customer customer)
        {
            this .customer = customer;
            InitializeComponent();
        }

        private void CusRetrieve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet6.TicketDb' table. You can move, or remove it, as needed.
            this.ticketDbTableAdapter.Fill(this.userDataDataSet6.TicketDb);
            tick = new TicketDb();
            db = new qlyticketDataContext();
            var list = (from s in db.TicketDbs where s.UserID == customer.Id select s).ToList();
            dataGridView1.DataSource = list;
            for (int i = 4; i <= 7; i++)
                dataGridView1.Columns[i].Visible = false;

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            db = new qlyticketDataContext();
            tick = db.TicketDbs.Where(s => s.TicketID == int.Parse(IdtickTextbox.Text)).Single();
            Ticket ticket = new Ticket(tick.TicketID, tick.UserID, tick.NameCustomer, tick.CarID, tick.Brand, tick.Color
                , tick.IDPark, tick.AreaPark, tick.DateIn, float.Parse(tick.Price.ToString()));
            ticket.openTicket();
        }

        private void Retrievebutton_Click(object sender, EventArgs e)
        {
            db = new qlyticketDataContext();
            tick = db.TicketDbs.Where(s => s.TicketID == int.Parse(IdtickTextbox.Text)).Single();
            Car car = new Car(tick.CarID, tick.UserID,tick.Brand, tick.Color, tick.IDPark);
            customer.Retrieve(car, tick.AreaPark,tick.DateIn, int.Parse(IdtickTextbox.Text));
            CusRetrieve_Load(sender, e);
        }
    }
}
