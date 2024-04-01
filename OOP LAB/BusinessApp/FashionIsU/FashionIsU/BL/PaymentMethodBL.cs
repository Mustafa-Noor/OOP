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
        

        public string GetPaymentType()
        {
            return PaymentType;
        }

        public void SetPaymentType(string paymentType)
        {
            PaymentType = paymentType;
        }

        public virtual int GetAmount(int amount)
        {
            
                amount = (int)(amount + amount*0.15);
            
            return amount;
        }

        
    }
}
