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
    public partial class AttendantForm : Form
    {
        //Attendant attendant;
        public AttendantForm()
        {
            InitializeComponent();
            //this.attendant = attendant;
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
            contentAtt_panel.Controls.Add(childForm);
            contentAtt_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void AttendantForm_Load(object sender, EventArgs e)
        {

        }

        private void parkCar_button_Click(object sender, EventArgs e)
        {
            if (preFormChild != null)
            {
                preFormChild.Close();
            }
            preFormChild = new AttParkCar();
            OpenChildForm(preFormChild);
        }
    }
}
