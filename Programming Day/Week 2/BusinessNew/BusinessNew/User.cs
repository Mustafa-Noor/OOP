using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessNew
{
    internal class User
    {
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
