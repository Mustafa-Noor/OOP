using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public class AdminBL:UserBL
    {
        private static AdminBL instance; // This is an instance of AdminBL
        private List<EmployeeBL> Employees; // List of Employees

        // Parametertized Constructor
        private AdminBL(string username, string password, string email, string firstName, string lastName, string phoneNumber, string role) : base(username, password, email, firstName, lastName, phoneNumber, role) 
        {
            Employees = new List<EmployeeBL>();
        }

        // Get the Instance of Admin
        public static AdminBL GetAdminBL()
        {
            if (instance == null)
            {
                instance = new AdminBL("admin", "123456", "admin@gmail.com", "Mustafa", "Noor", "0310-4682886", "admin");
            }
            return instance;
        }

        // Add an Employee
        public void AddEmployee(EmployeeBL employee)
        {
            Employees.Add(employee);
        }

        // Clear the List oF employees
        public void ClearEmployees()
        {
            Employees.Clear();
        }

        // Checks Admin Credentials
        public bool IsAdmin(UserBL user)
        {
            if(instance.GetUsername() == user.GetUsername() && instance.GetPassword() == user.GetPassword())
            {
                return true;
            }
            return false;
        }

        // Verfies existence of employee
        public bool CheckEmployeeExist(string username)
        {
            foreach (EmployeeBL emp in Employees)
            {
                if(emp.GetUsername() == username)
                { return true; }
            }
            return false;
        }

        // Find an employee from the List
        public EmployeeBL FindEmployee(UserBL user)
        {
            foreach (EmployeeBL emp in Employees)
            {
                if (emp.GetUsername() == user.GetUsername() && emp.GetPassword() == user.GetPassword())
                {
                    return emp;
                }
            }
            return null;
        }

        // Gives the list of all the Employees
        public List<EmployeeBL> GetAllEmployees()
        {
            return Employees;
        }

        // Checks the number of Employees
        public bool CheckEmployeesCount()
        { return Employees.Count > 0;}

        // Finds an Employee through their username
        public EmployeeBL FindEmployee(string username)
        {
            foreach (EmployeeBL emp in Employees)
            {
                if (emp.GetUsername() == username)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}
