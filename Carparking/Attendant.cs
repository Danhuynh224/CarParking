using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carparking
{
    public class Attendant : Person
    {
       
        private float salary;
        private int workingDay;
        public Attendant(int id, string name, string numerphone,  DateTime birthday, string role
            , int workingDay,  float salary ) : base(id,  name,numerphone, birthday, role)
        {
           
            this.salary = salary;    
            this.workingDay = workingDay;
        }
        public Attendant(int id, string name, string numerphone, DateTime birthday, string role
            ) : base(id, name, numerphone, birthday, role) { }


        public float Salary { get => salary; set => salary = value; }
        public int WorkingDay { get => workingDay; set => workingDay = value; }

        public void Park(int IDrequest,string carID, int ID, DateTime datepark)
        {
            
            qlycarparkingDataContext dbcp = new qlycarparkingDataContext();
            ParkingSpaceDb space = dbcp.ParkingSpaceDbs.Where(s => s.ID == ID).Single();
            space.Status = "Parked";
            space.IDCar = carID;
            space.DatePark = datepark;
            dbcp.SubmitChanges();
            MessageBox.Show("Park successfully");
            qlyrequestDataContext dbrq= new qlyrequestDataContext();
            ResquestDb resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == IDrequest).Single();
            dbrq.SubmitChanges();

        }
        public void Park(int IDrequest, string carID, string area, DateTime datepark)
        {
            qlycarparkingDataContext dbcp = new qlycarparkingDataContext();
            MessageBox.Show(area);
            ParkingSpaceDb space = null;
            space = dbcp.ParkingSpaceDbs.Where(s => s.Area==area && s.Status=="Empty" ).FirstOrDefault();
            if (space == null)
            {
                MessageBox.Show("No available space remaining!!!");
                return;
            }
            space.Status = "Parked";
            space.IDCar = carID;
            space.DatePark = datepark;
            dbcp.SubmitChanges();
            MessageBox.Show("Park successfully");
            qlyrequestDataContext dbrq = new qlyrequestDataContext();
            ResquestDb resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == IDrequest).Single();
            resquest.IDParkRequest = space.ID;        
            dbrq.SubmitChanges();
        }
        public void Park(int IDrequest, string carID, DateTime datepark)
        {
            qlycarparkingDataContext dbcp = new qlycarparkingDataContext();
            MessageBox.Show(".......");
            ParkingSpaceDb space = null;
            space = dbcp.ParkingSpaceDbs.Where(s=>s.Status == "Empty").FirstOrDefault();
            if(space == null)
            {
                MessageBox.Show("No available space remaining!!!");
                return;
            }    
            space.Status = "Parked";
            space.IDCar = carID;
            space.DatePark = datepark;
            dbcp.SubmitChanges();
            MessageBox.Show("Park successfully");
            qlyrequestDataContext dbrq = new qlyrequestDataContext();
            ResquestDb resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == IDrequest).Single();
            resquest.IDParkRequest = space.ID;
            resquest.AreaRequest = space.Area; 
            dbrq.SubmitChanges();
        }

        public void issueTicket(int IDrequest)
        {
            qlyrequestDataContext dbrq = new qlyrequestDataContext();
            ResquestDb resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == IDrequest).Single(); 
            
            qlycarparkingDataContext dbps = new qlycarparkingDataContext();
            ParkingSpaceDb space = dbps.ParkingSpaceDbs.Where(s => s.ID == resquest.IDParkRequest ).Single();
            if( space.Status!="Parked" ) {
                return;
            }
            qlyticketDataContext dbtk = new qlyticketDataContext();
            TicketDb ticket = new TicketDb();

            int idtk = dbtk.TicketDbs.Count() + 1;
            var b = dbtk.TicketDbs.Where(s => s.TicketID == idtk).FirstOrDefault();
            while (b != null)
            {
                idtk++;
                b = dbtk.TicketDbs.Where(s => s.TicketID == idtk).FirstOrDefault();
            }

            ticket.TicketID = idtk;
            ticket.UserID = resquest.IDCustomer;
            ticket.NameCustomer = resquest.Name;
            ticket.IDPark = resquest.IDParkRequest;
            ticket.CarID = resquest.IDCar;
            ticket.Brand = resquest.CarBrand;
            ticket.Color = resquest.Color;
            ticket.AreaPark = resquest.AreaRequest;
            ticket.Price = space.Price;
            ticket.DateIn = resquest.Date;
            dbtk.TicketDbs.InsertOnSubmit(ticket);
            dbtk.SubmitChanges();

            Ticket tick = new Ticket(ticket.TicketID, ticket.UserID, ticket.NameCustomer,
                ticket.CarID, ticket.Brand, ticket.Color, ticket.IDPark, ticket.AreaPark,
                 ticket.DateIn, float.Parse(ticket.Price.ToString()));
            tick.openTicket();
            dbrq.ResquestDbs.DeleteOnSubmit(resquest);
            dbrq.SubmitChanges();

        }
        public override string PrinfDetail()
        {
            return base.PrinfDetail()  + "\nSalary: " +salary;
        }
    }
}