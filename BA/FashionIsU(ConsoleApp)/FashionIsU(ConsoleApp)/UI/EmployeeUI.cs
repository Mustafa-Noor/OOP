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
        public static void EmployeeNotFound() // this shows that employee is not found
        {
            Console.WriteLine("Employee is not Found..");
            Thread.Sleep(300);
        }

        public static void EmployeeAdditionSuccess() // this shows that employee is added successfully
        {
            Console.WriteLine("Employee Successfully Added...");
            Thread.Sleep(300);
        }

        public static void EmployeeUpdateSuccess() // this show update is success
        {
            Console.WriteLine("Employee Successfully Updated...");
            Thread.Sleep(300);
        }
        public static void EmployeeDeleteSuccess() // this shows that employee is removed successfully
        {
            Console.WriteLine("Employee Successfully Removed...");
            Thread.Sleep(300);
        }

        public static void EmployeesNotFound() // this shows that there are no employees
        {
            Console.WriteLine("There are no Employees Yet....");
            Thread.Sleep(300);
        }

        public static string EmployeeMenu() // this displays the employee menu
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

        public static EmployeeBL TakeInputForEmployee() // this takes the input for adding an employee
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------ADD EMPLOYEE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Employee Username: ");
            string username = Console.ReadLine();
            username = ConsoleValidationUI.ValidateWords(username);
            Console.Write("Enter Password: ");
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
            Console.Write("Enter Employee Postion: ");
            string position = Console.ReadLine();
            position = ConsoleValidationUI.ValidatePosition(position);

            return new EmployeeBL(username, password, email, fname, lname, phone, "employee", position);
        }

        public static void UpdateProfileInput(EmployeeBL emp) // this takes the input for updating profile of employees
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE PROFILE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Password: ");
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
            

            emp.UpdateProfile(password, email, fname, lname, phone);
           
        }

        public static void DisplayEmployees(List<EmployeeBL> AllEmployees) // this display the list of employees
        {
            Console.WriteLine("--------------------------------DISPLAY ALL EMPLOYEES------------------------------------");
            Console.WriteLine();
            Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-20}|{4,-15}|{5,-10}|", "Username", "FirstName", "LastName", "Email", "PhoneNumber", "Position");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (EmployeeBL emp in AllEmployees)
            {
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-20}|{4,-15}|{5,-10}|", emp.GetUsername(), emp.GetFirstName(), emp.GetLastName(), emp.GetEmail(), emp.GetPhoneNumber(),emp.GetPosition());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }

        public static string TakeUsernameOfEmployee() // this takes the username of the employee
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter the Username of The Employee: " );
            string username = Console.ReadLine();
            username = ConsoleValidationUI.ValidateWords(username);
            return username;
        }

        public static void UpdateEmployeeInput(EmployeeBL emp) // this takes the input for updating the employee
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------UPDATE EMPLOYEE PAGE----------------------------");
            Console.WriteLine();
            Console.Write("Enter Password: ");
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
            Console.Write("Enter Employee Position: ");
            string position = Console.ReadLine();
            position = ConsoleValidationUI.ValidateWordsWithInt(position);

            EmployeeBL employee = new EmployeeBL(emp.GetUsername(), password, email, fname, lname, phone, emp.GetRole(), position);

            emp.UpdateProfile(employee);

        }

    }
}
