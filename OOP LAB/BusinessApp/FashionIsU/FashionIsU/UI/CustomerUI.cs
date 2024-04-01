using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class CustomerUI
    {
        public static CustomerBL TakeInfoCustomer(UserBL user)
        {
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            CustomerBL c = new CustomerBL(user, address);
            return c;
        }

        public static void CustomerNotFound()
        {
            Console.WriteLine("Customer is not Found..");
            Thread.Sleep(300);
        }

        public static string CustomerMenu()
        {
            Console.WriteLine("------------------------------CUSTOMER MENU----------------------------");
            Console.WriteLine();
            Console.WriteLine("1. VIEW LIST OF CLOTHES");
            Console.WriteLine("2. VIEW YOUR CART");
            Console.WriteLine("3. REMOVE AN ITEM FROM CART");
            Console.WriteLine("4. CHANGE THE QUANTITY");
            Console.WriteLine("5. PLACE ORDER");
            Console.WriteLine("6. CHECK PREVIOUS ORDERS");
            Console.WriteLine("7. LEAVE REVIEW FOR AN ITEM");
            Console.WriteLine("8. FIND THE TOTAL AMOUNT SPENT");
            Console.WriteLine("9. UPDATE PROFILE");
            Console.WriteLine("10. LOG OUT");
            Console.Write("ENTER YOUR CHOICE: ");
            string choice = Console.ReadLine();
            return choice;


        }

        public static void DisplayTotalAmountSpent(CustomerBL customer)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------TOTAL AMOUNT SPENT----------------------------");
            Console.WriteLine();
            float totalAmountSpent = customer.FindTotalAmountSpent();
            Console.WriteLine($"Total amount spent by {customer.GetFirstName()} {customer.GetLastName()}: Rs{totalAmountSpent}");
        }

        public static void UpdateProfileInput(CustomerBL cus, UserBL user)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE PROFILE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            cus.UpdateProfile(name, password, email, fname, lname, phone, address);
            user.UpdateProfile(name, password, email, fname, lname, phone);
            

        }

        

        public static void DisplayCustomers()
        {
            Console.WriteLine("--------------------------------DISPLAY ALL CUSTOMERS--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|{6,-15}|", "Username", "FirstName", "LastName", "Email", "PhoneNumber", "Address", "OrderCount");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            foreach (CustomerBL cus in CustomerDL.GetAllCustomers())
            {
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|{6,-15}|", cus.GetUsername(), cus.GetFirstName(), cus.GetLastName(), cus.GetEmail(), cus.GetPhoneNumber(), cus.GetCustomerAddress(), cus.GetOrdersCount());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }



        public static void NoCustomers()
        {
            Console.WriteLine();
            Console.WriteLine("There are no Custoemrs Yet...");
            Console.WriteLine();
            Thread.Sleep(300);
        }


        public static string TakeUsername()
        {
            Console.WriteLine();
            Console.Write("Enter the Username Of the Customer: ");
            string username = Console.ReadLine();
            return username;

        }

        
    }
}
