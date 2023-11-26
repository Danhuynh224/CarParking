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
        public Attendant(int id, string numerphone, string name, DateTime birthday, string role
            ,string areaPark, float salary ) : base(id, numerphone, name, birthday, role)
        {
            this.areaPark = areaPark;
            this.salary = salary;    
        }

        public string AreaPark { get => areaPark; set => areaPark = value; }
        public float Salary { get => salary; set => salary = value; }

        public override string PrinfDetail()
        {
            return base.PrinfDetail() + "\nAreaPark: " + areaPark + "\nSalary: " +salary;
        }
    }
}