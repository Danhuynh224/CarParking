using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carparking
{
    public class Car
    {
        private string carID;
        private int iDUser;
        private string carBrand;
        private string color;
        private int parkID;

        public Car(string carID, int iDUser, string carBrand, string color, int parkID)
        {
            this.carID = carID;
            this.iDUser = iDUser;
            this.carBrand = carBrand;
            this.color = color;
            this.parkID = parkID;

        }

        public string CarID { get => carID; set => carID = value; }
        public int IDUser { get => iDUser; set => iDUser = value; }
        public string CarBrand { get => carBrand; set => carBrand = value; }
        public int ParkID { get => parkID; set => parkID = value; }
        public string Color { get => color; set => color = value; }

        public string Showinfor()
        {
            string kq="";
            kq += "Car ID: " + CarID + "\nCar Brand:  "
                + CarBrand + "\nColor: " + Color+"\n";
            return kq;
        }
        public void addDb()
        {
            CarDb carDb = new CarDb();
            qlyCarDataContext db = new qlyCarDataContext();
           
            
                carDb.CarID = carID;
                carDb.ParkID = parkID;
                carDb.UserID = IDUser;
                carDb.CarBrand = carBrand;
                carDb.Color = color;
                db.CarDbs.InsertOnSubmit(carDb);
                db.SubmitChanges();
            
            
        }
    }
}
