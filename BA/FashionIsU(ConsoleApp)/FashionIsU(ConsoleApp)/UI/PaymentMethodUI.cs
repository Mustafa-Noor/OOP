using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class PaymentMethodUI
    {
        

        public static PaymentMethodBL TakeTypeOfPayment() // this takes the type of payment method
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------SELECT PAYMENT METHOD--------------------------------");
            Console.WriteLine("Cash on Delivery will cost 300Rs and Card will give you a Discount of 20%");
            Console.Write("Enter the Payment Type (Cash or Card): ");
            string type = Console.ReadLine();
            if (type.ToLower() == "card" || type.ToLower() == "cash")
            {
                return new PaymentMethodBL(type);
            }
            else
            {
                return null;
            }

        }


    }
}
