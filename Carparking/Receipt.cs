using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carparking
{
    public class Receipt
    {
        private int id;
        private string status;
        private int idUser;
        private string nameUser;
        private int idPark;
        private string areaPark;
        private string idCar;
        private string brand;
        private string color;
        private DateTime dateIn;
        private DateTime dateOut;
        private string payMethod;
        private float price;
        
        public Receipt(int id, string status,int idUser, string nameUser, int idPark, string areaPark, string idCar, string brand, string color,
            DateTime dateIn, DateTime dateOut, string payMethod, float price)
        {
            this.Id = id;
            this.Status = status;
            this.IdUser = idUser;
            this.NameUser = nameUser;
            this.IdPark = idPark;
            this.AreaPark = areaPark;
            this.IdCar = idCar;
            this.Brand = brand;
            this.Color = color;
            this.DateIn = dateIn;
            this.DateOut = dateOut;
            this.PayMethod = payMethod;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public int IdPark { get => idPark; set => idPark = value; }
        public string AreaPark { get => areaPark; set => areaPark = value; }
        public string IdCar { get => idCar; set => idCar = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime DateOut { get => dateOut; set => dateOut = value; }
        public string PayMethod { get => payMethod; set => payMethod = value; }
        public float Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }

        public void openReceipt()
        {
            ReceiptForm receipt= new ReceiptForm(this);
            receipt.Show();
        }

    }
    
}
