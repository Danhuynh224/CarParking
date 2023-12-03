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
    public partial class HandlePaymentForm : Form
    {
        Customer customer;
        qlyreceiptDataContext dbrp;
        ReceiptDb receiptdb;
        Receipt receipt;
        public HandlePaymentForm(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;
            pay_panel.Visible = false;
            receipt_panel.Visible = true;
        }

        private void HandlePaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet8.ReceiptDb' table. You can move, or remove it, as needed.
            this.receiptDbTableAdapter.Fill(this.userDataDataSet8.ReceiptDb);
            // TODO: This line of code loads data into the 'userDataDataSet8.ReceiptDb' table. You can move, or remove it, as needed.
            this.receiptDbTableAdapter.Fill(this.userDataDataSet8.ReceiptDb);

            receiptdb = new ReceiptDb();
            dbrp = new qlyreceiptDataContext();
            
            var list = (from s in dbrp.ReceiptDbs where s.IDUser == customer.Id select s).ToList();
            dataGridView1.DataSource = list;
        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            pay_panel.Visible = true;
            receipt_panel.Visible = false;
            dbrp = new qlyreceiptDataContext();
           
            receiptdb = dbrp.ReceiptDbs.Where(s => s.IDReceipt == int.Parse(idreceipt_textbox.Text)).Single();
            receipt = new Receipt(receiptdb.IDReceipt,receiptdb.Status, receiptdb.IDUser, receiptdb.NameUser, receiptdb.IDPark, receiptdb.AreaPark,
               receiptdb.IDCar, receiptdb.Brand, receiptdb.Color, receiptdb.DateIn, receiptdb.DateOut,
               receiptdb.PaymentMethod, float.Parse(receiptdb.Price.ToString()));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            dbrp = new qlyreceiptDataContext();
            receiptdb = dbrp.ReceiptDbs.Where(s => s.IDReceipt == int.Parse(idreceipt_textbox.Text)).Single();
            receipt = new Receipt(receiptdb.IDReceipt,receiptdb.Status, receiptdb.IDUser, receiptdb.NameUser, receiptdb.IDPark, receiptdb.AreaPark,
               receiptdb.IDCar, receiptdb.Brand, receiptdb.Color, receiptdb.DateIn, receiptdb.DateOut,
               receiptdb.PaymentMethod, float.Parse(receiptdb.Price.ToString()));
            receipt.openReceipt();
        }

        private void cash_button_Click(object sender, EventArgs e)
        {
            customer.HandlePayment(receipt,cash_button.Text);
        }

        private void visa_button_Click(object sender, EventArgs e)
        {
            customer.HandlePayment(receipt, visa_button.Text);
        }

        private void banking_button_Click(object sender, EventArgs e)
        {
            customer.HandlePayment(receipt, banking_button.Text);
        }
    }
}
