using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsU
{
    internal class Cash: PaymentMethodBL
    {
        public Cash(string type) : base(type) { }

        public override int GetAmount(int amount)
        {

            amount = base.GetAmount(amount);

            amount = amount + 300;

            return amount;
        }

        public Cash MakeCashObject(string type)
        {
            Cash c = new Cash(type);
            return c;
        }
    }
}
