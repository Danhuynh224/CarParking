using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carparking
{
    public class Customer : Person
    {
        List<Car> cars;
       
        public Customer(int id, string name, string numerphone, DateTime birthday, string role 
        ): base(id, name, numerphone, birthday, role)
        {
           CarDb carDb = new CarDb();   
           qlyCarDataContext db= new qlyCarDataContext();
            Cars = new List<Car>();
            var list = (from s in db.CarDbs
                        where s.UserID == id
                        select s).ToList();
            for(int i = 0;i<list.Count;i++)
            {
                Car car = new Car(list[i].CarID, id, list[i].CarBrand, list[i].Color, list[i].ParkID);
                Cars.Add(car);
            }
            MessageBox.Show(PrinfDetail());
        }

        internal List<Car> Cars { get => cars; set => cars = value; }

        public override string PrinfDetail()
        {
            string carinfor = "";
            for(int i = 0; i < Cars.Count; i++)
            {
                carinfor += Cars[i].Showinfor();
            }
            return base.PrinfDetail() + carinfor;
        }
        public void Park(Car car,int ID,DateTime datepark)
        {
            
            Cars.Add(car);
            car.addDb();
            qlycarparkingDataContext dbcp = new qlycarparkingDataContext();
            ParkingSpaceDb space = dbcp.ParkingSpaceDbs.Where(s => s.ID == ID).Single();
            space.Status = "Parked";
            space.IDCar = car.CarID;
            space.DatePark= datepark;
            dbcp.SubmitChanges();
            MessageBox.Show("Park successfully");

        }
    }
}