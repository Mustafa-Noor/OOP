using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU.UI
{
    internal class UserUI
    {
        public static UserBL SignUpWindowforUser()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN UP--------------------------------");
            Console.WriteLine();
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
            string lname= Console.ReadLine();
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter the Type Of User (Customer, Employee, Admin) : ");
            string type = Console.ReadLine();


            UserBL u = new UserBL(name, password, email, fname, lname, phone, type);
            return u;

        }

        public static void CongratsforSignup()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed up.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        public static void CongratsforSignin()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("You have successfully signed in.");
            Console.Write("Press any key to continue...");
            Console.Read();
        }

        public static UserBL SignInWindow()
        {

            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN IN--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();
            

            UserBL nUser = new UserBL(Name, Password);
            return nUser;


        }

        public static void PrintUserTaken()
        {
            Console.WriteLine("User ALready Exist...");
            Thread.Sleep(300);
        }

        public static void PrintUserNotFound()
        {
            Console.WriteLine("User Not Found...");
            Thread.Sleep(300);
        }

        public static void IncorrectRole()
        {
            Console.WriteLine("Incorrect role...");
            Thread.Sleep(300);
        }

        
    }
}
