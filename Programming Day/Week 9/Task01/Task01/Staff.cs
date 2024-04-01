using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Staff:Person
    {
        private string school;
        private double pay;

        public Staff(string Name, string address, string school, double pay) : base(Name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string GetSchool()
        {
            return school;
        }

        public void SetSchool(string value)
        {
            school = value;
        }

        public double GetPay()
        {
            return pay;
        }

        public void SetPay(double value)
        {
            pay = value;
        }

        public new string toString()
        {
            string result = "Staff[" + base.toString() + ", school = " + school + ", pay = " + pay + "]";
            return result;
        }

    }
}
