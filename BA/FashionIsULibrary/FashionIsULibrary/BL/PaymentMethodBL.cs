using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class PaymentMethodBL
    {
        
        private string PaymentType; // payment type attribute

        public PaymentMethodBL(string type)
        {
            
            PaymentType = type;
        }

        // caluclates the amount depending upon type
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

        // Getter and Setter
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
