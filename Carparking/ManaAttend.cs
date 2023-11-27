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
    public partial class ManaAttend : Form
    {
        UserLogin user;
        qlyuserloginDataContext db;
        AttendantDb attendant;
        qlyattendantDataContext atdb;
        Manager manager;
        public ManaAttend(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void ManaAttend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet.AttendantDb' table. You can move, or remove it, as needed.
            this.attendantDbTableAdapter.Fill(this.userDataDataSet.AttendantDb);

            attendant =new AttendantDb();
            atdb = new qlyattendantDataContext();
            var list = (from s in atdb.AttendantDbs select s).ToList(); 
            dataGridView1.DataSource = list;
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
             try
            { 
                Attendant attendant = new Attendant(Int32.Parse(IDtextBox.Text), fullnametextBox.Text, phonetextBox.Text, birthdateTimePicker.Value,"Attendant", 
                    AreaParktextBox.Text, Int32.Parse(WorkdaytextBox.Text), float.Parse(SalarytextBox.Text));
                manager.AddAttendant(attendant);
                db = new qlyuserloginDataContext();
                user = db.UserLogins.Where(s => s.ID == attendant.Id && s.Role == "Attendant").Single();
                MessageBox.Show("Tai khoan dang nhap: " + user.Username + "\nMau khau la: 123");
                ManaAttend_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot add an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            user = new UserLogin();
            db = new qlyuserloginDataContext();
            try
            {
                manager.DeleteAttendant(Int32.Parse(IDtextBox.Text));
                ManaAttend_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot edit an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (WorkdaytextBox.Text == "")
                    WorkdaytextBox.Text = "32";
                if (SalarytextBox.Text == "")
                    SalarytextBox.Text = "0";
                Attendant attendant = new Attendant(Int32.Parse(IDtextBox.Text), fullnametextBox.Text, phonetextBox.Text, birthdateTimePicker.Value, "Attendant",
                    AreaParktextBox.Text, Int32.Parse(WorkdaytextBox.Text), float.Parse(SalarytextBox.Text));    
                manager.EditAttendant(attendant);
                if (WorkdaytextBox.Text == "32")
                    WorkdaytextBox.Text = "";
                if (SalarytextBox.Text == "0")
                    SalarytextBox.Text = "";
                ManaAttend_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot edit an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ByIDtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in atdb.AttendantDbs
                        where s.ID.ToString().Contains(ByIDtextBox.Text)
                        select s).ToList();
            
            IDtextBox.DataBindings.Clear();
            fullnametextBox.DataBindings.Clear();
            phonetextBox.DataBindings.Clear();
            AreaParktextBox.DataBindings.Clear();
            WorkdaytextBox.DataBindings.Clear();
            SalarytextBox.DataBindings.Clear();
            birthdateTimePicker.DataBindings.Clear();
            IDtextBox.DataBindings.Add("text", list, "ID");
            fullnametextBox.DataBindings.Add("text", list, "Fullname");
            phonetextBox.DataBindings.Add("text", list, "Phone");
            birthdateTimePicker.DataBindings.Add("Value", list, "Birthday");
            AreaParktextBox.DataBindings.Add("text", list, "AreaPark");
            WorkdaytextBox.DataBindings.Add("text", list, "NumberCarAssisted");
            SalarytextBox.DataBindings.Add("text", list, "Salary");
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchByNametextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var list = (from s in atdb.AttendantDbs
                        where s.Fullname.Contains(SearchByNametextBox.Text)
                        select s).ToList();

            IDtextBox.DataBindings.Clear();
            fullnametextBox.DataBindings.Clear();
            phonetextBox.DataBindings.Clear();
            AreaParktextBox.DataBindings.Clear();
            WorkdaytextBox.DataBindings.Clear();
            SalarytextBox.DataBindings.Clear();
            birthdateTimePicker.DataBindings.Clear();
            IDtextBox.DataBindings.Add("text", list, "ID");
            fullnametextBox.DataBindings.Add("text", list, "Fullname");
            phonetextBox.DataBindings.Add("text", list, "Phone");
            birthdateTimePicker.DataBindings.Add("Value", list, "Birthday");
            AreaParktextBox.DataBindings.Add("text", list, "AreaPark");
            WorkdaytextBox.DataBindings.Add("text", list, "NumberCarAssisted");
            SalarytextBox.DataBindings.Add("text", list, "Salary");
            dataGridView1.DataSource = list;
        }
        static string GetUserName(string fullname)
        {
            string[] names = fullname.Split(' ');
            return names[names.Length - 1];
        }
    }
    
}
