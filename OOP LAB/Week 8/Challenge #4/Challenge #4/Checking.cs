using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__4
{
    internal class Checking:Account
    {
        private float Tax;
        public float GetTax()
        {
            return Tax;
        }
        public void SetTax(float tax)
        {
            this.Tax = tax;
        }
        public Checking(string AccountNumber, float balance, float tax) : base(AccountNumber, balance)
        {
            this.Tax = tax;
        }
        
    }
}
