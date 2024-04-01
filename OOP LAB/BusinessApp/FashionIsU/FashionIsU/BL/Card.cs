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
        private int Pin;

        public Card(string type,string company, int pin) :base (type)
        {
            Company = company;
            Pin = pin;
        }

        private void SetPin(int pin)
        {
            Pin = pin;
        }

        private int GetPin()
        { return Pin; }


        private void SetCompany(string company)
        {
            Company = company;
        }

        private string GetCompany()
        { return Company; }

        public override float GetAmount(float amount)
        {

            amount = base.GetAmount(amount);

            amount = amount - amount * 0.20f;

            return amount;
        }



    }
}
