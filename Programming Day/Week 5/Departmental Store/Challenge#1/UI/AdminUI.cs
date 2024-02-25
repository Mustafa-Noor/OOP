using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class AdminUI
    {
        public static string AdminMenu()
        {
            Console.WriteLine("------ADMIN MENU--------");
            Console.WriteLine();
            Console.WriteLine("1. ADD PRODUCT");
            Console.WriteLine("2. VIEW ALL PRODUCTS");
            Console.WriteLine("3. FIND PRODUCT WITH HIGHEST PRICE");
            Console.WriteLine("4. VIEW SALES TAX OF ALL PRODUCTS");
            Console.WriteLine("5. PRODUCTS TO BE ORDERED");
            Console.WriteLine("6. VIEW PROFILE");
            Console.WriteLine("7. RETURN");
            Console.Write("ENTER YOUR CHOICE: ");
            string Choice = Console.ReadLine();
            return Choice;
        }
    }
}
