using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task01
{
    internal class Person
    {
        private string Name;
        private string address;

        public Person(string name, string address)
        {
            Name = name;
            this.address = address;
        }
        public string getName()
        {
            return Name;
        }
        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        { this.address = address; }

        public string toString()
        {
            return $"(Person[name = {Name}, address = {address}])";
        }
    }
}
