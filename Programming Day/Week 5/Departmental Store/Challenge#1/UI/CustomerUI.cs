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

        public static CustomerBL TakeDetailsCus(UserBL u)
        {
            Console.Write("Enter your Email: ");
            string Email = Console.ReadLine();
            Console.Write("Enter your Contact Number: ");
            string Contact = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string Address = Console.ReadLine();

            CustomerBL c = new CustomerBL(u.UserName, u.Password, Email, Contact, Address);
            return c;

        }

        public static void NotPossible()
        {
            Console.WriteLine("Not Possible...");
            Thread.Sleep(200);
        }

        public static void GenerateInvoice(CustomerBL c)
        {
            Console.WriteLine("Invoice:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("| Product Name | Price | Quantity | Total    |");
            Console.WriteLine("----------------------------------------------");

            float overallTotal = 0;

            foreach (ProductBL product in c.BoughtProducts)
            {
                float total = product.CalculateTotal();
                overallTotal += total;
                Console.WriteLine($"| {product.NameOfProduct,-12} | {product.ProductPrice,5:C2} | {product.AvailableStock,8} | {total,8:C2} |");
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"| Overall Total: {overallTotal,34:C2} |");
            Console.WriteLine("----------------------------------------------");
        }

        public static void ViewProfile(CustomerBL c)
        {
            Console.WriteLine("User Profile:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Username:       {c.UserName}");
            Console.WriteLine($"Password:       {c.Password}");
            Console.WriteLine($"Email:          {c.Email}");
            Console.WriteLine($"Address:        {c.Address}");
            Console.WriteLine($"Contact Number: {c.PhoneNumber}");
            Console.WriteLine("-------------------------------------------------");
        }

        public static void DisplayCustomerInformation()
        {
            Console.WriteLine("Customer Information:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("| Username | Password | Email           | Address   | Contact Number |");
            Console.WriteLine("--------------------------------------------------------");

            foreach (CustomerBL customer in CustomerDL.Customers)
            {
                
                Console.WriteLine($"| {customer.UserName,-9} | {customer.Password,-9} | {customer.Email,-15} | {customer.Address,-10} | {customer.PhoneNumber,-14} |");
                
            }

            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
