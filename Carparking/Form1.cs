using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;

namespace Carparking
{
    public partial class Form1 : Form
    {
        UserLogin user=new UserLogin();
        
        qlyuserloginDataContext db=new qlyuserloginDataContext();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            
            bool check = manager_radioButton.Checked || attendant_radioButton.Checked || customer_radioButton.Checked;
            try
            {
                if(UsertextBox.Text!=null && passwordtextBox.Text != null && check == true)
                {
                    UserLogin i = null;
                    if(manager_radioButton.Checked == true)
                        i = db.UserLogins.Where(s => s.Username == UsertextBox.Text && s.Pass == passwordtextBox.Text && s.Role == "Manager").FirstOrDefault();
                    else if(attendant_radioButton.Checked == true)
                        i = db.UserLogins.Where(s => s.Username == UsertextBox.Text && s.Pass == passwordtextBox.Text && s.Role == "Attendant").FirstOrDefault();
                    else if(customer_radioButton.Checked == true)
                        i = db.UserLogins.Where(s => s.Username == UsertextBox.Text && s.Pass == passwordtextBox.Text && s.Role == "Customer").FirstOrDefault();
                
                    if (i != null)
                    {
                        if (manager_radioButton.Checked)
                        {
                            Manager manager = new Manager(i.ID, i.Fullname, i.NumberPhone,  i.Birthday.Value ,i.Role);
                            this.Hide();
                            ManagerForm managerform = new ManagerForm(manager);
                            managerform.ShowDialog();
                            this.Show();
                        }
                        else if (attendant_radioButton.Checked)
                        {
                            Attendant attendant = new Attendant(i.ID, i.NumberPhone, i.Fullname, i.Birthday.Value, i.Role);
                            this.Hide();
                            AttendantForm attendantForm = new AttendantForm(attendant);
                            attendantForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            Customer customer = new Customer(i.ID, i.Fullname, i.NumberPhone,  i.Birthday.Value, i.Role);
                            this.Hide();
                            CustomerForm customerform = new CustomerForm(customer);
                            customerform.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại Tên đăng nhập, Mật khẩu, hoặc Vị trí");
                    }    
                }
                else
                {
                    MessageBox.Show("Please fill all blank fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Sumit_button_Click(object sender, EventArgs e)
        {
            bool check = signmanager_radioButton.Checked || signattendant_radioButton.Checked || signcustomer_radioButton.Checked;

            try
            {
                if(check == false || signnametextBox.Text == "" || passagtextBox.Text == "" || passsignBox.Text == "" || fnametextBox.Text=="")
                    MessageBox.Show("Please fill all blank fields");
                else if (passsignBox.Text != passagtextBox.Text)
                        MessageBox.Show("Error pasword! Please fill again");

                else
                {
                    var i = db.UserLogins.Where(s => s.Username == signnametextBox.Text).FirstOrDefault();                 
                    if (i != null)
                        MessageBox.Show("Username exists");
                    else
                    {
                        
                        user.Username = signnametextBox.Text;
                        user.Fullname=fnametextBox.Text;
                        user.Pass=passsignBox.Text;
                        user.NumberPhone = phonentextBox.Text;
                        user.Birthday = birthdateTimePicker.Value;
                        if (signmanager_radioButton.Checked)
                        {
                            user.Role = "Manager";
                            ManagerDb managerDb = new ManagerDb();
                            qlymanagerDataContext dbmn = new qlymanagerDataContext();
                            int id = dbmn.ManagerDbs.Count();
                            var b = dbmn.ManagerDbs.Where(s => s.ID == id).FirstOrDefault();
                            while (b != null)
                            {
                                id++;
                                b = dbmn.ManagerDbs.Where(s => s.ID == id).FirstOrDefault();
                            }
                            managerDb.ID = id;
                            user.ID= managerDb.ID;
                            managerDb.Fullname = user.Fullname;
                            managerDb.Phone = user.NumberPhone;
                            dbmn.ManagerDbs.InsertOnSubmit(managerDb);
                            dbmn.SubmitChanges();
                        }
                        else if (signattendant_radioButton.Checked)
                        {
                            user.Role = "Attendant";
                            AttendantDb attendantDb = new AttendantDb();
                            qlyattendantDataContext dbat = new qlyattendantDataContext();
                            int id = dbat.AttendantDbs.Count();
                            var b = dbat.AttendantDbs.Where(s => s.ID == id).FirstOrDefault();
                            while (b != null)
                            {
                                id++;
                                b = dbat.AttendantDbs.Where(s => s.ID == id).FirstOrDefault();
                            }
                            attendantDb.ID = id;
                            user.ID= attendantDb.ID;    
                            attendantDb.Fullname = user.Fullname;
                            attendantDb.Phone = user.NumberPhone;
                            dbat.AttendantDbs.InsertOnSubmit(attendantDb);
                            dbat.SubmitChanges();

                        }
                        else if (signcustomer_radioButton.Checked)
                        {
                            user.Role = "Customer";
                            CustomerDb customerDb = new CustomerDb();
                            qlycustomerDataContext dbct = new qlycustomerDataContext();
                            int id = dbct.CustomerDbs.Count();
                            var b = dbct.CustomerDbs.Where(s => s.ID == id).FirstOrDefault();
                            while (b != null)
                            {
                                id++;
                                b = dbct.CustomerDbs.Where(s => s.ID == id).FirstOrDefault();
                            }
                            customerDb.ID = id;
                            user.ID= customerDb.ID; 
                            customerDb.Fullname = user.Fullname;
                            customerDb.Phone = user.NumberPhone;
                            dbct.CustomerDbs.InsertOnSubmit(customerDb);
                            dbct.SubmitChanges();

                        }
                        db.UserLogins.InsertOnSubmit(user);
                        db.SubmitChanges();
                        MessageBox.Show("Sign up successfull");
                        signnametextBox.Text = "";
                        passagtextBox.Text = "";
                        passsignBox.Text = "";
                        phonentextBox.Text = "";
                        panel1.Visible = true;
                        panel2.Visible = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sign up error!");
            }
                
        }

        private void backlogin_button_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
