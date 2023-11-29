using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carparking
{
    public abstract class Person
    {
        private string numerphone;
        private string name;
        private string role;
        private int id;
        private DateTime birthDay;
        public Person()
        {
           
        }
        public Person(int id, string name, string numerphone, DateTime birthday, string role)
        {
            this.id = id;
            this.numerphone = numerphone;
            this.name = name;
            this.BirthDay = birthday;
            this.role = role;
        }
        public string Numerphone { get => numerphone; set => numerphone = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public int Id { get => id; set => id = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }

        virtual public string PrinfDetail()
        {
            return "ID: " + id.ToString() + "\nName: " + name + "\nNumerPhone: " + numerphone + "\nBirthday: " + BirthDay.ToShortDateString() + "\nRole: " + role+"\n";
        }
    }
}