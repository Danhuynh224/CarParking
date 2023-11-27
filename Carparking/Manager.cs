using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carparking
{
    public class Manager : Person
    {
        private int numberstaff;

        public Manager()
        {
            throw new System.NotImplementedException();
        }
        public Manager(int id, string name, string numerphone, DateTime birthday, string role): base(id, name, numerphone, birthday, role)
        {
            
        }

        public override string PrinfDetail()
        {
            return base.PrinfDetail() + "\nNumber staff"+numberstaff;
        }
        public void ManageCarparking()
        {
            //ManaCarParking manaCarparking = new ManaCarParking();
            //manaCarparking.ShowDialog();
        }
        public void ManageAttendant()
        {
            //ManaAttend manaAttend = new ManaAttend();
            //manaAttend.ShowDialog();
        }
        public void AddAttendant(Attendant atten)
        {
            int number = 0;
            AttendantDb attendant=new AttendantDb();
            qlyattendantDataContext atdb=new qlyattendantDataContext();
            UserLogin user = new UserLogin();
            qlyuserloginDataContext db = new qlyuserloginDataContext();
            attendant.ID = atten.Id;
            attendant.Fullname = atten.Name;
            attendant.Phone = atten.Numerphone;
            attendant.Birthday = atten.BirthDay.Date;
            attendant.AreaPark = atten.AreaPark;
            attendant.WorkingDay = atten.WorkingDay;
            attendant.Salary = atten.Salary;
            user.ID = atten.Id;
            string username = GetUserName(attendant.Fullname);
            var b = db.UserLogins.Where(s => s.Username == username).FirstOrDefault();
            while (b != null)
            {
                number++;
                username.Remove(username.Length - 1);
                username = username + number.ToString();
                b = db.UserLogins.Where(s => s.Username == username).FirstOrDefault();
            }
            user.Username = username;
            user.Pass = "123";
            user.Fullname = atten.Name;
            user.NumberPhone = atten.Numerphone;
            user.Birthday = atten.BirthDay.Date;
            user.Role = "Attendant";
            atdb.AttendantDbs.InsertOnSubmit(attendant);
            atdb.SubmitChanges();
            db.UserLogins.InsertOnSubmit(user);
            db.SubmitChanges();         
        }
        public void EditAttendant(Attendant atten)
        {
            AttendantDb attendant = new AttendantDb();
            qlyattendantDataContext atdb = new qlyattendantDataContext();
            UserLogin user=new UserLogin(); 
            qlyuserloginDataContext db = new qlyuserloginDataContext();
            attendant = atdb.AttendantDbs.Where(s => s.ID == atten.Id).Single();
            user = db.UserLogins.Where(s => s.ID == atten.Id && s.Role == "Attendant").Single();
            if (atten.Name != "")
            {
                attendant.Fullname = atten.Name;
                user.Fullname = attendant.Fullname;
            }
            if (atten.Numerphone != "")
            {
                attendant.Phone = atten.Numerphone;
                user.NumberPhone = attendant.Phone;
            }
            if (atten.BirthDay.Date != DateTime.Now.Date)
            {
                attendant.Birthday = atten.BirthDay.Date;
                user.Birthday = attendant.Birthday;
            }
            if (atten.AreaPark != "") attendant.AreaPark = atten.AreaPark;
            if (atten.WorkingDay!=32) attendant.WorkingDay = atten.WorkingDay;
            if (atten.Salary != 0) attendant.Salary = atten.Salary;
            atdb.SubmitChanges();
            db.SubmitChanges();
        }
        public void DeleteAttendant(int Id)
        {
            AttendantDb attendant = new AttendantDb();
            qlyattendantDataContext atdb = new qlyattendantDataContext();
            UserLogin user = new UserLogin();
            qlyuserloginDataContext db = new qlyuserloginDataContext();
            attendant = atdb.AttendantDbs.Where(s => s.ID == Id).Single();
            user = db.UserLogins.Where(s => s.ID == Id && s.Role == "Attendant").Single();
            atdb.AttendantDbs.DeleteOnSubmit(attendant);
            db.UserLogins.DeleteOnSubmit(user);
            atdb.SubmitChanges();
            db.SubmitChanges();
        }
        public void AddCarParking(ParkingSpace carspace)
        {
            ParkingSpaceDb space=new ParkingSpaceDb();
            qlycarparkingDataContext db=new qlycarparkingDataContext();
            space.ID = carspace.ID;
            space.Status = carspace.Status;
            space.Price = carspace.Price;
            space.IDCar = carspace.IDCar;
            space.Area = carspace.Area;
            space.ParkedDays = 0;
            db.ParkingSpaceDbs.InsertOnSubmit(space);
            db.SubmitChanges();
        }
        public void EditCarParking(ParkingSpace carspace)
        {
            ParkingSpaceDb space = new ParkingSpaceDb();
            qlycarparkingDataContext db = new qlycarparkingDataContext();
            space = db.ParkingSpaceDbs.Where(s => s.ID == carspace.ID).Single();
            if (carspace.Area != "")
                space.Area = carspace.Area;
            if (carspace.Price!=0)
                space.Price = carspace.Price;   
            db.SubmitChanges();
        }
        public void DeleteCarParking(int ID)
        {
            ParkingSpaceDb space = new ParkingSpaceDb();
            qlycarparkingDataContext db = new qlycarparkingDataContext();
            space = db.ParkingSpaceDbs.Where(s => s.ID == ID).Single();
            db.ParkingSpaceDbs.DeleteOnSubmit(space);
            db.SubmitChanges();
            
        }
        static string GetUserName(string fullname)
        {
            string[] names = fullname.Split(' ');
            return names[names.Length - 1];
        }
    }

    
}