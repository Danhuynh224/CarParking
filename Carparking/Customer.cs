﻿using System;
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

        public void Request(Car car , string areapark, DateTime date) 
        {
            Cars.Add(car);
            car.addDb();
            ResquestDb rq = new ResquestDb();
            qlyrequestDataContext dbrq = new qlyrequestDataContext();
            rq.IDRequest = dbrq.ResquestDbs.Count()+1;
            rq.IDCustomer = car.IDUser;
            rq.CarBrand = car.CarBrand;
            rq.IDCar = car.CarID;
            rq.IDParkRequest = car.ParkID;
            rq.AreaRequest = areapark;
            rq.Name = Name;
            rq.Color = car.Color;
            rq.Date = date;

            if (car.ParkID != 0)
            {
                qlycarparkingDataContext dbcp = new qlycarparkingDataContext();
                ParkingSpaceDb space = dbcp.ParkingSpaceDbs.Where(s => s.ID == car.ParkID).Single();
                space.Status = "Requesting";
                dbcp.SubmitChanges();
            }
            dbrq.ResquestDbs.InsertOnSubmit(rq);
            dbrq.SubmitChanges();
        }
    }
}