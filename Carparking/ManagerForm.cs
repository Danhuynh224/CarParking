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
    public partial class ManagerForm : Form
    {
        Manager manager;
        public ManagerForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
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
            content_panel.Controls.Add(childForm);
            content_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void carparingbutton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //manager.ManageCarparking();
            //this.Show();
            if (preFormChild != null)
            {
                preFormChild.Close();
            }
            preFormChild = new ManaCarParking();
            OpenChildForm(preFormChild);
        }

        private void Attendent_button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //manager.ManageAttendant();
            //this.Show();
            if (preFormChild != null)
            {
                preFormChild.Close();
            }
            preFormChild = new ManaAttend();
            OpenChildForm(preFormChild);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
