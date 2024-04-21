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
        private static AdminBL instance;
        private List<EmployeeBL> Employees;
        private AdminBL(string username, string password, string email, string firstName, string lastName, string phoneNumber, string role) : base(username, password, email, firstName, lastName, phoneNumber, role) 
        {
            Employees = new List<EmployeeBL>();
        }

        public static AdminBL GetAdminBL()
        {
            if (instance == null)
            {
                instance = new AdminBL("admin", "123456", "admin@gmail.com", "Mustafa", "Noor", "0310-4682886", "admin");
            }
            return instance;
        }

        public void AddEmployee(EmployeeBL employee)
        {
            Employees.Add(employee);
        }

        public void ClearEmployees()
        {
            Employees.Clear();
        }

        public bool IsAdmin(UserBL user)
        {
            if(instance.GetUsername() == user.GetUsername() && instance.GetPassword() == user.GetPassword())
            {
                return true;
            }
            return false;
        }

        public bool CheckEmployeeExist(string username)
        {
            foreach (EmployeeBL emp in Employees)
            {
                if(emp.GetUsername() == username)
                { return true; }
            }
            return false;
        }

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

        public List<EmployeeBL> GetAllEmployees()
        {
            return Employees;
        }

        public bool CheckEmployeesCount()
        { return Employees.Count > 0;}

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
