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
        public ManaAttend()
        {
            InitializeComponent();
        }

        private void ManaAttend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet7.AttendantDb' table. You can move, or remove it, as needed.
            this.attendantDbTableAdapter3.Fill(this.userDataDataSet7.AttendantDb);
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
                int number=0;
                attendant.ID = Int32.Parse(IDtextBox.Text);
                attendant.Fullname = fullnametextBox.Text;
                attendant.Phone = phonetextBox.Text;
                attendant.Birthday = birthdateTimePicker.Value.Date;
                attendant.AreaPark = AreaParktextBox.Text;
                attendant.WorkingDay = Int32.Parse(WorkdaytextBox.Text);
                attendant.Salary = float.Parse(SalarytextBox.Text);
                user = new UserLogin();
                db = new qlyuserloginDataContext();
                user.ID = attendant.ID;
                string username= GetUserName(attendant.Fullname);
                var b = db.UserLogins.Where(s => s.Username == username).FirstOrDefault();
                while (b != null)
                {
                    number++;
                    username=username+number.ToString();
                    b = db.UserLogins.Where(s => s.Username == username).FirstOrDefault();
                }
                user.Username = username;
                user.Pass = "123";
                user.Fullname=attendant.Fullname;
                user.NumberPhone = attendant.Phone;
                user.Birthday =attendant.Birthday;
                user.Role = "Attendant";
                MessageBox.Show("Tai khoan dang nhap: " + user.Username + "\nMau khau la: 123");
                atdb.AttendantDbs.InsertOnSubmit(attendant);
                atdb.SubmitChanges();
                db.UserLogins.InsertOnSubmit(user);
                db.SubmitChanges();
                ManaAttend_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot add an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                attendant = atdb.AttendantDbs.Where(s => s.ID == Int32.Parse(IDtextBox.Text)).Single();
                atdb.AttendantDbs.DeleteOnSubmit(attendant);
                atdb.SubmitChanges();
                user = db.UserLogins.Where(s => s.ID == Int32.Parse(IDtextBox.Text) && s.Role== "Attendant").Single();
                db.UserLogins.DeleteOnSubmit(user);
                db.SubmitChanges();
                ManaAttend_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cannot edit an entity that already exist.", "Loi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        static string GetUserName(string fullname)
        {
            string[] names = fullname.Split(' ');
            return names[names.Length - 1];
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                user = new UserLogin();
                db = new qlyuserloginDataContext();
                
                attendant = atdb.AttendantDbs.Where(s => s.ID == Int32.Parse(IDtextBox.Text)).Single();
                user = db.UserLogins.Where(s => s.ID == Int32.Parse(IDtextBox.Text) && s.Role == "Attendant").Single();
                if (fullnametextBox.Text != "")
                {
                    attendant.Fullname = fullnametextBox.Text;
                    user.Fullname = attendant.Fullname;
                }
                if (phonetextBox.Text != "")
                {
                    attendant.Phone = phonetextBox.Text;
                    user.NumberPhone = attendant.Phone;
                }
                if (birthdateTimePicker.Value.Date != DateTime.Now.Date) {
                    attendant.Birthday = birthdateTimePicker.Value.Date;
                        user.Birthday = attendant.Birthday; }
                if(AreaParktextBox.Text!="") attendant.AreaPark = AreaParktextBox.Text;
                if(WorkdaytextBox.Text!="") attendant.WorkingDay = Int32.Parse(WorkdaytextBox.Text);
                if(SalarytextBox.Text!="") attendant.Salary = float.Parse(SalarytextBox.Text);            
                atdb.SubmitChanges();
                db.SubmitChanges();
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
    }
    
}
