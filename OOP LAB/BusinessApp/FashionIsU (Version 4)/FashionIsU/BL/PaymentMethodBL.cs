using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class PaymentMethodBL
    {
        
        private string PaymentType;

        public PaymentMethodBL(string type)
        {
            
            PaymentType = type;
        }

        public int GetAmount(int amount)
        {
            if (PaymentType.ToLower() == "cash")
            {
                amount = amount + 300;
            }
            else
            {
                amount = (int)(amount - amount * 0.20);
            }

            return amount;
        }


        public void SetPaymentType(string paymentType)
        {
            PaymentType = paymentType;
        }

        public string GetPaymentType()
        {
            return PaymentType;
        }
        

        
    }
}
