using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__3
{
    internal class Staff:Person
    {
        private string School;
        private double Pay;

        public Staff(string name, string address ,string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public string GetSchool()
        { return School; }

        public void SetSchool(string school)
        {
            this.School = school;

        }

        public double GetPay() { return Pay; }  
        public void SetPay(double pay) {  this.Pay = pay; }

    }
}
