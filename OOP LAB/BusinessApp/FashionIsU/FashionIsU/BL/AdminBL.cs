using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class AdminBL : UserBL
    {
        private string Description;

        public AdminBL (string username, string password, string email, string firstName,string lastName, string phoneNumber,string role, string description) : base(username, password, email, firstName, lastName, phoneNumber, role)
        {
            this.Description = description;
        }


        public AdminBL(UserBL user, string description) : base(user)
        {
            Description = description;
        }

        public string GetDescription()
        {
            return Description;
        }

        // Setter method for Description
        public void SetDescription(string desc)
        {
            Description = desc;
        }
    }
}
