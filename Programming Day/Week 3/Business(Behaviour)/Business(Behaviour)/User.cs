using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Behaviour_
{
    internal class User
    {
        public User(string name, string password1)
        {
            this.username = name;
            this.password = password1;  
        }
        public User(string name, string password1, string role1)
        {
            username = name;
            password = password1;
            role = role1;

        }
        public string username;
        public string password;
        public string role;

    }
}
