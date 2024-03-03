using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class AuthorBL
    {
        private string Name;
        private string Email;
        private string Gender;

        public AuthorBL(string name, string email, string gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public bool SetName(string name)
        {
            if(name!=null)
            {
                this.Name = name;
                return true;
            }

            return false;
        }

        public string GetName()
        {
            return this.Name;
        }

        public bool SetEmail(string email)
        {
            if (email != null)
            {
                this.Email = email;
                return true;
            }

            return false;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public bool SetGender(string gender)
        {
            if (gender == "male" || gender == "female")
            {
                this.Gender = gender;
                return true;
            }

            return false;
        }

        public string GetGender()
        {
            return this.Gender;
        }




    }
}
