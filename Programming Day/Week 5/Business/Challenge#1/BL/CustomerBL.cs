using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class CustomerBL
    {
        public string UserName;
        public string Password;
        public string Email;
        public string PhoneNumber;
        public string Address;

        public List<ProductBL> BoughtProducts = new List<ProductBL>();

       public CustomerBL(string userName, string password, string email, string phoneNumber, string address)
        {
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public CustomerBL(string userName, string password, string email, string phoneNumber, string address, List<ProductBL> boughtProducts){
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            BoughtProducts = boughtProducts;
        }

        public void AddBoughtItem(ProductBL p)
        {
            BoughtProducts.Add(p);
        }
    }
}
