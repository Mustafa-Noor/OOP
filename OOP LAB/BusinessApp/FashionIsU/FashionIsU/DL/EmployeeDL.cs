using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class EmployeeDL
    {
        private static List <EmployeeBL> Employees = new List <EmployeeBL> ();

        public static void AddEmployee(EmployeeBL emp)
        {
            Employees.Add (emp);
        }

        public static EmployeeBL FindEmployee(UserBL user)
        {
            foreach(EmployeeBL emp in Employees)
            {
                if(emp.GetUsername() == user.GetUsername() && emp.GetPassword() == user.GetPassword())
                {
                    return emp;
                }
            }

            return null;
        }
    }
}
