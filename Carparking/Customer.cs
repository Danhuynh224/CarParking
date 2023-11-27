using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carparking
{
    public class Customer : Person
    {

        private int carID;
        private int carRetrieve;
        private float paid;
        private string payMethod;

        public Customer(int id, string name, string numerphone, DateTime birthday, string role, 
            int carID, int carRetrieve, float paid, string payMethod): base(id, name, numerphone, birthday, role)
        {
            this.carID = carID;
            this.carRetrieve = carRetrieve;
            this.paid = paid;
            this.payMethod = payMethod;
        }

        public int CarID { get => carID; set => carID = value; }
        public int CarRetrieve { get => carRetrieve; set => carRetrieve = value; }
        public float Paid { get => paid; set => paid = value; }
        public string PayMethod { get => payMethod; set => payMethod = value; }


        public override string PrinfDetail()
        {
            return base.PrinfDetail() + "\nCarID: " + carID + "\nCarRetrieve: " + carRetrieve + "\nPayMethod: " + payMethod ;
        }
    }
}