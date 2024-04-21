using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface ICustomerDL
    {
        bool AddCustomer(CustomerBL customer);
        void UpdateProfile(CustomerBL customer);
        bool IsCustomerExists(string username);
        CustomerBL FindCustomer(UserBL user);
        List<CustomerBL> GetAllCustomers();
        bool CheckCustomersCount();
        CustomerBL FindCustomerByUsername(string username);
    }
}
