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
    public partial class ReceiptForm : Form
    {
        Receipt receipt;
        public ReceiptForm(Receipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
            idticket_label.Text = receipt.Id.ToString();
            customerid_label.Text = receipt.IdUser.ToString();
            name_label.Text = receipt.NameUser.ToString();
            carid_label.Text = receipt.IdCar.ToString();
            brand_label.Text = receipt.Brand.ToString();
            color_label.Text = receipt.Color.ToString();
            idpark_label.Text = receipt.IdPark.ToString();
            area_label.Text = receipt.AreaPark.ToString();
            datein_label.Text = receipt.DateIn.ToString();
            price_label.Text = receipt.Price.ToString();
            dateout_label.Text= receipt.DateOut.ToString();
            paymethod_label.Text = receipt.PayMethod;
            statuslabel.Text = receipt.Status;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            if(paymethod_label.Text== "N/A")
                confirmbutton.Visible = false;
            else confirmbutton.Visible = true;
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pay Successfully");
            this.Close();
        }
    }
}
