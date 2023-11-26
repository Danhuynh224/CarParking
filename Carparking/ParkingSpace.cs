using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carparking
{
    public class ParkingSpace
    {
        private int iD;
        private string status;
        private float price;
        private string iDCar;
        private string area;
        private int parkedDays;

        public ParkingSpace(int iD, string status, float price, string iDCar, string area, int parkedDays)
        {
            this.ID = iD;
            this.Status = status;
            this.Price = price;
            this.IDCar = iDCar;
            this.Area = area;
            this.ParkedDays = parkedDays;
        }

        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public float Price { get => price; set => price = value; }
        public string IDCar { get => iDCar; set => iDCar = value; }
        public string Area { get => area; set => area = value; }
        public int ParkedDays { get => parkedDays; set => parkedDays = value; }
        public float getMoney()
        {
            return price*parkedDays;
        }
    }
}