using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal abstract class PaymentMethodBL
    {
        
        private string PaymentType;

        public PaymentMethodBL(string type)
        {
            
            PaymentType = type;
        }
        

        public string GetPaymentType()
        {
            return PaymentType;
        }

        public void SetPaymentType(string paymentType)
        {
            PaymentType = paymentType;
        }

        public abstract int GetAmount(int amount);
        

        
    }
}
