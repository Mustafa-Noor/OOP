using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class UserUI
    {
        public static UserBL SigninWindow()
        {
            Console.WriteLine();
            Console.WriteLine("--------Sign In----------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();

            UserBL u = new UserBL(Name, Password);
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

        public static UserBL SignupWindow()
        {

            Console.WriteLine();
            Console.WriteLine("--------Sign Up----------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();
            Console.Write("Enter Role (Admin or Customer): ");
            string Role = Console.ReadLine();
            Console.WriteLine();

            UserBL nUser = new UserBL(Name, Password,Role);
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
