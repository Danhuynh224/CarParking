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
    
    public partial class CustomerForm : Form
    {
        Customer customer;
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private Form currentFormChild;
        private Form preFormChild = null;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentCus_panel.Controls.Add(childForm);
            contentCus_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void parkCar_button_Click(object sender, EventArgs e)
        {
            if (preFormChild != null)
            {
                preFormChild.Close();
            }
            preFormChild = new CusBookTicket(customer);
            OpenChildForm(preFormChild);
        }
    }
}
