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

        

    }
}
