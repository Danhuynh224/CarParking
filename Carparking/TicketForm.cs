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
    public partial class TicketForm : Form
    {
       
        Ticket ticket;
       
        public TicketForm(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            idticket_label.Text = ticket.Id.ToString();
            customerid_label.Text = ticket.IdUser.ToString();
            name_label.Text = ticket.NameCustomer.ToString();
            carid_label.Text = ticket.CarId.ToString();
            brand_label.Text = ticket.Brand.ToString();
            color_label.Text = ticket.Color.ToString();
            idpark_label.Text = ticket.IdPark.ToString();   
            area_label.Text = ticket.AreaPark.ToString();
            datein_label.Text = ticket.DateIn.ToString();
            price_label.Text = ticket.Price.ToString();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }

        private void printTicket_button_Click(object sender, EventArgs e)
        {

        }
    }
}
