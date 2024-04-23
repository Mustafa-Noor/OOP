using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU_ConsoleApp_.UI
{
    internal class AdminUI
    {
        public static void AdminNotFound() // shows that admin is not found
        {
            Console.WriteLine("Admin is not Found..");
            Thread.Sleep(300);
        }

        public static string AdminMenu() // displays the admin menu
        {
            Console.WriteLine("------------------------------ADMIN MENU----------------------------");
            Console.WriteLine();
            Console.WriteLine("1. ADD AN EMPLOYEE");
            Console.WriteLine("2. VIEW ALL EMPLOYEES");
            Console.WriteLine("3. UPDATE DETAILS OF AN EMPLOYEE");
            Console.WriteLine("4. DELETE AN AN EMPLOYEE");
            Console.WriteLine("5. VIEW LIST OF CUTOMERS");
            Console.WriteLine("6. LOG OUT");
            Console.Write("ENTER YOUR CHOICE: ");
            string choice = Console.ReadLine();
            return choice;

        }
    }
}
