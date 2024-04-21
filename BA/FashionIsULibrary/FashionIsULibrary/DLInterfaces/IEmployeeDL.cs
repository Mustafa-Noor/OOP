using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface IEmployeeDL
    {
        bool AddEmployee(EmployeeBL employee);
        void RetrieveEmployees(AdminBL admin);
        void UpdateProfile(EmployeeBL employee);
        List<EmployeeBL> GetAllEmployees();
        bool DeleteEmployee(EmployeeBL employee);
    }
}
