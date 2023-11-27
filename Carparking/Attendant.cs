using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carparking
{
    public class Attendant : Person
    {
        private string areaPark;
        private float salary;
        private int workingDay;
        public Attendant(int id, string name, string numerphone,  DateTime birthday, string role
            ,string areaPark, int workingDay,  float salary ) : base(id,  name,numerphone, birthday, role)
        {
            this.areaPark = areaPark;
            this.salary = salary;    
            this.workingDay = workingDay;
        }

        public string AreaPark { get => areaPark; set => areaPark = value; }
        public float Salary { get => salary; set => salary = value; }
        public int WorkingDay { get => workingDay; set => workingDay = value; }

        public void ParkCar()
        {

        }
        public override string PrinfDetail()
        {
            return base.PrinfDetail() + "\nAreaPark: " + areaPark + "\nSalary: " +salary;
        }
    }
}