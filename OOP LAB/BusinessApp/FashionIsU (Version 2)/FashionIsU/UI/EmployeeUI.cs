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
        public static  EmployeeBL TakeInfoForEmployee(UserBL u)
        {
           

            EmployeeBL emp = new EmployeeBL(u);
            return emp;
        }

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

        public static void UpdateProfileInput(EmployeeBL emp, UserBL user)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE PROFILE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            name = ConsoleUtility.ValidateWords(name);
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            password = ConsoleUtility.RestrictPassword(password);
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            email = ConsoleUtility.ValidateEmail(email);
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            fname = ConsoleUtility.ValidateWordsWithInt(fname);
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            lname = ConsoleUtility.ValidateWordsWithInt(lname);
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            phone = ConsoleUtility.ValidateContact(phone);
            

            emp.UpdateProfile(name, password, email, fname, lname, phone);
            user.UpdateProfile(name, password, email, fname, lname, phone);


        }
    }
}
