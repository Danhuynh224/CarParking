using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carparking
{
    public class Ticket
    {
        private int id;
        private int idUser;
        private string carId;
        private int idPark;
        private string areaPark;
        private DateTime dateIn;
        private float price;
        private string nameCustomer;
        private string brand;
        private string color;

        public int IdUser { get => idUser; set => idUser = value; }
        public int IdPark { get => idPark; set => idPark = value; }
        public string AreaPark { get => areaPark; set => areaPark = value; }
        public float Price { get => price; set => price = value; }
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public int Id { get => id; set => id = value; }
        public string CarId { get => carId; set => carId = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }

        public Ticket(int id, int idUser, string nameCustomer,string carId, string brand, string color, int idPark, string areaPark, DateTime dateIn, float price)
        {
            this.id = id;
            this.idUser = idUser;
            this.carId = carId;
            this.brand = brand;
            this.color = color;
            this.idPark = idPark;
            this.areaPark = areaPark;
            this.DateIn = dateIn;
            this.price = price;
            this.nameCustomer = nameCustomer;
        }

        public void openTicket()
        {
            TicketForm tkform = new TicketForm(this);
            tkform.Show();
        }

        public string printDetailTicket()
        {
            return "\n----------------------------\n" +
                "\nIdTicket: " + Id + "\nIdUser: " + idUser + "\nNameCustomer: " + nameCustomer + "\nIdCar: " 
                + CarId  + "\nIdPark: " + "\nBrand: " + brand + "\nColor: " + color
                + "\nIDPark" +idPark + "\nAreaPark: " + areaPark + "\nDateIn: " + DateIn.ToString() + "\nPrice: " + price 
                + "\n\n----------------------------\n";
        }
    }
}