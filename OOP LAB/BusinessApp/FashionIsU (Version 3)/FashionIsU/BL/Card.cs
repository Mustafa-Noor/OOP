using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    internal class Card : PaymentMethodBL
    {
        private string Company;
        private string Pin;

        public Card(string type,string company, string  pin) :base (type)
        {
            Company = company;
            Pin = pin;
        }

        private void SetPin(string pin)
        {
            Pin = pin;
        }

        private string GetPin()
        { return Pin; }


        private void SetCompany(string company)
        {
            Company = company;
        }

        private string GetCompany()
        { return Company; }

        public override int GetAmount(int amount)
        {
            amount = (int)(amount - amount * 0.20);

            return amount;
        }



    }
}
