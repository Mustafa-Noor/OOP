using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class CustomerUI
    {

        public static CustomerBL CreateCustomer() // this takes input for signing up customer
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN UP FOR CUSTOMER--------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            name = ConsoleValidationUI.ValidateWords(name);

            Console.Write("Enter Password (Must be 6-Digits): ");
            string password = Console.ReadLine();
            password = ConsoleValidationUI.RestrictPassword(password);

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            email = ConsoleValidationUI.ValidateEmail(email);

            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            fname = ConsoleValidationUI.ValidateWordsWithInt(fname);

            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            lname = ConsoleValidationUI.ValidateWordsWithInt(lname);

            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            phone = ConsoleValidationUI.ValidateContact(phone);

            return new CustomerBL(name, password, email, fname, lname, phone, "customer");
        }

        public static void CongratsforSignup() // this congratulates custoemr for signing up
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed up.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        public static void CustomerNotFound() // this shows that customer is not found
        {
            Console.WriteLine("Customer is not Found..");
            Thread.Sleep(300);
        }

        public static string CustomerMenu() // this displays the customer is not found
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

        public static void DisplayTotalAmountSpent(CustomerBL customer) // this displays the total amount spent
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------TOTAL AMOUNT SPENT----------------------------");
            Console.WriteLine();
            float totalAmountSpent = customer.FindTotalAmountSpent();
            Console.WriteLine($"Total amount spent by {customer.GetFirstName()} {customer.GetLastName()}: Rs{totalAmountSpent}:C");
        }

        public static void UpdateProfileInput(CustomerBL cus) // this takes the input for updating the profile of customer
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE PROFILE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Password(6-Digits): ");
            string password = Console.ReadLine();
            password = ConsoleValidationUI.RestrictPassword(password);
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            email = ConsoleValidationUI.ValidateEmail(email);
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            fname = ConsoleValidationUI.ValidateWordsWithInt(fname);
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            lname = ConsoleValidationUI.ValidateWordsWithInt(lname);
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            phone = ConsoleValidationUI.ValidateContact(phone);


            cus.UpdateProfile(password, email, fname, lname, phone) ;
            
            

        }

        public static void DisplayCustomers(List<CustomerBL> AllCustomers) // this displays the list of customers
        {
            Console.WriteLine("--------------------------------DISPLAY ALL CUSTOMERS------------------------------------");
            Console.WriteLine();
            Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-20}|{4,-15}", "Username", "FirstName", "LastName", "Email", "PhoneNumber");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (CustomerBL cus in AllCustomers)
            {
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-20}|{4,-15}", cus.GetUsername(), cus.GetFirstName(), cus.GetLastName(), cus.GetEmail(), cus.GetPhoneNumber());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }



        public static void NoCustomers() // this shows that there are not customers
        {
            Console.WriteLine();
            Console.WriteLine("There are no Custoemrs Yet...");
            Console.WriteLine();
            Thread.Sleep(300);
        }


        public static string TakeUsername() // this takes the username of the customer
        {
            Console.WriteLine();
            Console.Write("Enter the Username Of the Customer: ");
            string username = Console.ReadLine();
            username = ConsoleValidationUI.ValidateWords(username);
            return username;

        }

        
    }
}
