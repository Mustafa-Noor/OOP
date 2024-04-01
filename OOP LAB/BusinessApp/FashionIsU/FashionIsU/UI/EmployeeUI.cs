using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class EmployeeUI
    {
        public static  EmployeeBL TakeInfoForEmployee(UserBL u)
        {
            Console.WriteLine();
            Console.WriteLine("For Employee: ");
            Console.WriteLine();
            Console.Write("Enter Employee Position: ");
            string position = Console.ReadLine();
            Console.Write("Enter Employee Qualification: ");
            string qualification = Console.ReadLine();

            EmployeeBL emp = new EmployeeBL(u, position, qualification);
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
    }
}
