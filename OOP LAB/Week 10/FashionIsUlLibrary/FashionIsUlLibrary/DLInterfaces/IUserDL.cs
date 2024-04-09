using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FashionIsU;

namespace FashionIsUlLibrary
{
    public interface IUserDL
    {
        bool AddUser(UserBL user);
        void UpdateProfile(UserBL user);
        bool IsUserExists(UserBL cUser);
        UserBL FindUser(UserBL u);
        List<CustomerBL> GetAllCustomers();
        bool CheckCustomersCount();
        CustomerBL FindCustomerByUsername(string username);

    }
}
