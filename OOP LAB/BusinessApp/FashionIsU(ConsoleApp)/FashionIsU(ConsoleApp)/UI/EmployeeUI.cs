using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FashionIsU.UI;

namespace FashionIsU
{
    internal class EmployeeUI
    {
       

        public static void EmployeeNotFound()
        {
            Console.WriteLine("Employee is not Found..");
            Thread.Sleep(300);
        }

        public static string EmployeeMenu()
        {
            Console.WriteLine("------------------------------EMPLOYEE MENU----------------------------");
            Console.WriteLine();
            Console.WriteLine("1. VIEW LIST OF CLOTHES");
            Console.WriteLine("2. ADD AN ITEM OF CLOTHING");
            Console.WriteLine("3. UPDATE AN ITEM OF CLOTHING");
            Console.WriteLine("4. DELETE AN ITEM OF CLOTHING");
            Console.WriteLine("5. VIEW LIST OF CUTOMERS");
            Console.WriteLine("6. VIEW LIST OF ORDERS");
            Console.WriteLine("7. CHECK REVIEWS FOR AN ITEM");
            Console.WriteLine("8. UPDATE YOUR PROFILE");
            Console.WriteLine("9. LOG OUT");
            Console.Write("ENTER YOUR CHOICE: ");
            string choice = Console.ReadLine();
            return  choice;

        }

        public static void UpdateProfileInput(EmployeeBL emp)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE PROFILE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            password = ConsoleValidation.RestrictPassword(password);
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            email = ConsoleValidation.ValidateEmail(email);
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            fname = ConsoleValidation.ValidateWordsWithInt(fname);
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            lname = ConsoleValidation.ValidateWordsWithInt(lname);
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            phone = ConsoleValidation.ValidateContact(phone);
            

            emp.UpdateProfile(password, email, fname, lname, phone);
           


        }
    }
}
