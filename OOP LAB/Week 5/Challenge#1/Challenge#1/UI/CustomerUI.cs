using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class CustomerUI
    {
        public static string CustomerMenu()
        {
            Console.WriteLine("------Customer MENU--------");
            Console.WriteLine();
            Console.WriteLine("1. VIEW ALL PRODUCTS");
            Console.WriteLine("2. BUY THE PRODUCTS");
            Console.WriteLine("3. GENERATE INVOICE");
            Console.WriteLine("4. VIEW PROFILE");
            Console.WriteLine("5. RETURN");
            Console.Write("ENTER YOUR CHOICE: ");
            string Choice = Console.ReadLine();
            return Choice;
        }

        public static void NotPossible()
        {
            Console.WriteLine("Not Possible...");
            Thread.Sleep(200);
        }

        public static void GenerateInvoice(UserBL u)
        {
            Console.WriteLine("Invoice:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| Product Name | Price | Quantity | Total    |");
            Console.WriteLine("----------------------------------------------");

            float overallTotal = 0;

            foreach (ProductBL product in u.BoughtProducts)
            {
                float total = product.CalculateTotal();
                overallTotal += total;
                Console.WriteLine($"| {product.NameOfProduct,-12} | {product.ProductPrice,5:C2} | {product.AvailableStock,8} | {total,8:C2} |");
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"| Overall Total: {overallTotal,34:C2} |");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
