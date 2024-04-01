using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class PaymentMethodUI
    {
        public static Card TakeInputForCard(string type)
        {
            Console.WriteLine();
            Console.Write("Enter The Name of Card Company: ");
            string company = Console.ReadLine();
            Console.Write("Enter Your 4-Digit Pin: ");
            int pin = int.Parse(Console.ReadLine());

            Card cd = new Card(type, company, pin);
            return cd;
        }

        public static PaymentMethodBL TakeTypeOfPayment()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------SELECT PAYMENT METHOD--------------------------------");
            Console.WriteLine("Cash on Delivery will cost 300Rs and Card will give you a Discount of 20%");
            Console.Write("Enter the Payment Type (Cash or Card): ");
            string type = Console.ReadLine();
            if(type == "Card" || type == "card")
            {
                Card c = TakeInputForCard(type);
                return c;
            }
            else if (type == "Cash" || type == "cash")
            {
                Cash c = new Cash(type);
                return c;
            }
            else
            {
                return null;
            }

        }


    }
}
