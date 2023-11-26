using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carparking
{
    public class Manager : Person
    {
        private int numberstaff;

        public Manager()
        {
            throw new System.NotImplementedException();
        }
        public Manager(int id, string numerphone, string name, DateTime birthday, string role): base(id,numerphone,name, birthday, role)
        {
            
        }

        public override string PrinfDetail()
        {
            return base.PrinfDetail() + "\nNumber staff"+numberstaff;
        }
        public void ManageCarparking()
        {
            ManaCarParking manaCarparking = new ManaCarParking();
            manaCarparking.ShowDialog();
        }
        public void ManageAttendant()
        {
            ManaAttend manaAttend = new ManaAttend();
            manaAttend.ShowDialog();
        }
    }
}