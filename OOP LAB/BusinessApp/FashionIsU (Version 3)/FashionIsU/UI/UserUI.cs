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
        /*
        public static UserBL SignUpWindowforUser()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN UP--------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            name = ConsoleUtility.ValidateWords(name);
            Console.Write("Enter Password (Must be 6-Digits): ");
            string password = Console.ReadLine();
            password = ConsoleUtility.RestrictPassword(password);
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            email = ConsoleUtility.ValidateEmail(email);
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            fname = ConsoleUtility.ValidateWordsWithInt(fname);
            Console.Write("Enter Last Name: ");
            string lname= Console.ReadLine();
            lname = ConsoleUtility.ValidateWordsWithInt(lname);
            Console.Write("Enter Contact Number: ");
            string phone = Console.ReadLine();
            phone = ConsoleUtility.ValidateContact(phone);
            


            UserBL u = new UserBL(name, password, email, fname, lname, phone, type);
            return u;

        }
        */

        public static UserBL CreateUser(string role)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN UP--------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string name = Console.ReadLine();
            name = ConsoleUtility.ValidateWords(name);

            Console.Write("Enter Password (Must be 6-Digits): ");
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

            if (role.ToLower() == "customer")
            {
                return new CustomerBL(name, password, email, fname, lname, phone, role);
            }
            else if (role.ToLower() == "employee")
            {

                return new EmployeeBL(name, password, email, fname, lname, phone, role);
            }
            else
            {
                throw new ArgumentException("Invalid role");
            }
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

        

        public static UserBL SignInWindow(string role)
        {

            Console.WriteLine();
            Console.WriteLine("---------------------------------SIGN IN--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            Name = ConsoleUtility.ValidateWords(Name);
            Console.Write("Enter Password (6-Digits): ");
            string Password = Console.ReadLine();
            Password = ConsoleUtility.RestrictPassword(Password);
            if (role.ToLower() == "customer")
            {
                return new CustomerBL(Name, Password);
            }
            else if (role.ToLower() == "employee")
            {
                return new EmployeeBL(Name, Password);
            }
            else
            {
                throw new ArgumentException("Invalid role");
            }
            


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

        public static void ProfileUpdateSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("Profile Has Been Updated Successfully...");
            Console.WriteLine();
            Thread.Sleep(300);
        }


        public static string TakeRole()
        {
            Console.WriteLine();
            Console.Write("Enter your Role (Employee or Customer): ");
            string role = Console.ReadLine();
            role = ConsoleUtility.GetValidRole(role);
            return role;

        }


    }
}
