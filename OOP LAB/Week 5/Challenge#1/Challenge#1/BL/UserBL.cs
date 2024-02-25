using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class UserBL
    {
        public string UserName;
        public string Password;
        public string Role;
        public string Email;
        public string PhoneNumber;
        public string Address;

        public List <ProductBL> BoughtProducts = new List <ProductBL>();

        public UserBL(string Name, string Password)
        {
            this.UserName = Name;
            this.Password = Password;
        }
        public UserBL(string Name, string Password, string Role)
        {
            UserName = Name;
            this.Password = Password;
            this.Role = Role;

        }

        public void SetDetailsCus(string Email, string PhoneNumber, string Address)
        {
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public void AddBoughtItem(ProductBL p)
        {
            BoughtProducts.Add(p);
        }

    }
}
