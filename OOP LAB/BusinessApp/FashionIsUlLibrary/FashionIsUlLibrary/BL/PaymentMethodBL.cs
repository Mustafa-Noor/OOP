using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public abstract class PaymentMethodBL
    {
        private int PaymentMethodID;
        private string PaymentType;

        public PaymentMethodBL(string type)
        {
            
            PaymentType = type;
        }

        public PaymentMethodBL(int id, string type)
        {
            PaymentMethodID = id;
            PaymentType = type;
        }
        

        private int GetPaymentId()
        { return PaymentMethodID; }


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
