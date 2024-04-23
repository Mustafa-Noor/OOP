using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FashionIsU.UI
{
    internal class UserUI
    {
        

        public static void CongratsforSignin() // this shows that sign in is success
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed in.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        

        public static UserBL SignInWindow(string role) // this takes input for sign in
        {

            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN IN--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            Name = ConsoleValidationUI.ValidateWords(Name);
            Console.Write("Enter Password (6-Digits): ");
            string Password = Console.ReadLine();
            Password = ConsoleValidationUI.RestrictPassword(Password);
            if (role.ToLower() == "customer")
            {
                return new CustomerBL(Name, Password);
            }
            else
            {
                return new EmployeeBL(Name, Password);
            }
        }
        

        public static void PrintUserTaken() // this shows that user is already tkaen
        {
            Console.WriteLine("User ALready Exist...");
            Thread.Sleep(300);
        }

        public static void PrintUserNotFound() // this show that user is not found
        {
            Console.WriteLine("User Not Found...");
            Thread.Sleep(300);
        }

        public static void IncorrectRole() // this shows that role is incoorect
        {
            Console.WriteLine("Incorrect role...");
            Thread.Sleep(300);
        }

        public static void ProfileUpdateSuccess() // this shows that profile update is success
        {
            Console.WriteLine();
            Console.WriteLine("Profile Has Been Updated Successfully...");
            Console.WriteLine();
            Thread.Sleep(300);
        }


        public static string TakeRole() // this takes input regarding role
        {
            Console.WriteLine();
            Console.Write("Enter your Role (Admin, Employee or Customer): ");
            string role = Console.ReadLine();
            role = ConsoleValidationUI.GetValidRole(role);
            return role;

        }


    }
}
