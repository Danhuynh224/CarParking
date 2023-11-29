using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carparking
{
    public partial class CusRequestForm : Form
    {
        ParkingSpaceDb space;
        Customer customer;
        qlycarparkingDataContext db;

        public CusRequestForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void CusRequestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet16.ParkingSpaceDb' table. You can move, or remove it, as needed.
            this.parkingSpaceDbTableAdapter.Fill(this.userDataDataSet16.ParkingSpaceDb);
          
            space = new ParkingSpaceDb();
            db = new qlycarparkingDataContext();
            var list = (from s in db.ParkingSpaceDbs where s.Status == "Empty" select s).ToList();
            idpark_textbox.Text = "Optional";
            arearq_textbox.Text = "Optional";
            dataGridView1.DataSource = list;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void arearq_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.Area.Contains(arearq_textbox.Text) && s.Status == "Empty"
                        select s).ToList();
            idpark_textbox.DataBindings.Clear();
            dataGridView1.DataSource = list;
        }
        private void idpark_textbox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in db.ParkingSpaceDbs
                        where s.ID.ToString().Contains(idpark_textbox.Text) && s.Status=="Empty"
                        select s).ToList();
            arearq_textbox.DataBindings.Clear();
            arearq_textbox.DataBindings.Add("text", list, "Area");
            dataGridView1.DataSource = list;
        }
        private void arearq_textbox_Click(object sender, EventArgs e)
        {
            arearq_textbox.Text = "";
            idpark_textbox.Text = "";
        }

        private void idpark_textbox_Click(object sender, EventArgs e)
        { 
            idpark_textbox.Text ="";
        }

        private void sendreq_button_Click(object sender, EventArgs e)
        {
            bool checkid = false;
            if (idpark_textbox.Text == "" || idpark_textbox.Text == "Optional")
            {
                idpark_textbox.Text = "0";
                checkid  = true;
            }
            else
            {   
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (idpark_textbox.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                       
                        checkid = true;
                        break;
                        
                    }
                }
            }

            bool checkarea = false;
            if (arearq_textbox.Text == "Optional")
            {
                arearq_textbox.Text = "";
                checkarea = true;
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                    if (arearq_textbox.Text == dataGridView1.Rows[i].Cells[1].Value.ToString()) ;
                    {
                        checkarea = true;
                        break;
                    }
                }
            }
            


            if (checkid == true && checkarea == true)
            {
                Car car = new Car(idcar_textbox.Text, customer.Id, carbrand_textbox.Text, color_textbox.Text, int.Parse(idpark_textbox.Text));
                customer.Request(car, arearq_textbox.Text, dateTimePicker1.Value.Date);
                CusRequestForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fill again IDRequest or AreaRequest");
            }
            CusRequestForm_Load(sender, e);
        }

        
    }
}
