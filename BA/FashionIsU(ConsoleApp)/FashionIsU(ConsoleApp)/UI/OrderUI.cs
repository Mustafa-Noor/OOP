using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FashionIsU;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class OrderUI
    {
        public static OrderBL TakeInputForOrder(CustomerBL customer, PaymentMethodBL pm) // this takes the input for order of customer
        {
            int price = pm.GetAmount(customer.GetCart().GetTotalCartAmount());
            Console.WriteLine();
            Console.WriteLine("--------------------------------PLACE YOUR ORDER---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Your Total Price (After PaymentMethod) : Rs " + price);
            Console.Write("Enter Your Delivery Address : ");
            string address = Console.ReadLine();
            address = ConsoleValidationUI.ValidateSentences(address);

            OrderBL order = new OrderBL(customer.GetCart().GetCartItems(), price, address, new PaymentMethodBL(pm.GetPaymentType()), customer.GetUsername()) ;
            return order;
        }


        public static void OrderSuccessful() // this shows that order made succes
        {
            Console.WriteLine();
            Console.WriteLine("Your Order has Been Made Successfully...");
            Console.WriteLine();
            Thread.Sleep(300);
        }

        public static void NeverPlaced() // this shows that they have not placed any order
        {
            Console.WriteLine();
            Console.WriteLine("Your Have Not Placed An Order Before...");
            Console.WriteLine();
            Thread.Sleep(300);
        }

        public static void DisplayOrders(List<OrderBL> orders) // this displays the orders
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-14}|{1,-60}|{2,-13}|{3,-21}|{4,-15}|", "Order Date", "Items", "Total Price", "Delivery Address", "Payment Type");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");

            foreach (OrderBL order in orders)
            {
                Console.WriteLine($"|{order.GetOrderDate().ToString("yyyy-MM-dd"),-14}|{FormatItems(order.GetItems()),-60}|Rs{order.GetTotalPrice(),-11}|{order.GetDeliveryAddress(),-21}|{order.GetPaymentMethod().GetPaymentType(),-15}|");
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
        }


        private static string FormatItems(List<ClothesBL> items) // this format the items for displayng in orders
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append(item.GetType()).Append(", ");
            }
            return sb.ToString().TrimEnd(',', ' ');
        }
    }
}
