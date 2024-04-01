using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInUp.BL
{
    internal class MUserBL
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public MUserBL(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public MUserBL(string userName, string userPassword) 
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }

        public string getUserName()
        {
            return this.userName;
            
        }

        public string getUserPassword()
        { return this.userPassword; }

        public string getUserRole()
        {
            return this.userRole;
        }

        public bool isAdmin() 
        { 
            if(userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
