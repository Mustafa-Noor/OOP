using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class UserBL
    {
        // protected attributes (parent class)
        protected string Username;
        protected string Password;
        protected string Email;
        protected string FirstName;
        protected string LastName;
        protected string PhoneNumber;
        protected string Role;

        // paramterized constructors 
        public UserBL(string username, string password, string email, string firstName, string lastName, string phoneNumber, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            this.Role = role;
        }

        public UserBL(UserBL user) 
        {
            this.Username = user.GetUsername();
            this.Password = user.GetPassword();
            this.Email = user.GetEmail();
            this.FirstName = user.GetFirstName();
            this.LastName = user.GetLastName();
            this.PhoneNumber = user.GetPhoneNumber();
            this.Role = user.GetRole();

        }


        public UserBL(string username, string password) 
        {
            Username = username;
            Password = password;

        }

        
        // Getter and setters 
        public string GetRole()
        {
            return Role;
        }
        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string value)
        {
            Username = value;
        }

        // Getter and setter methods for Password
        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string value)
        {
            Password = value;
        }

        // Getter and setter methods for Email
        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string value)
        {
            Email = value;
        }

        // Getter and setter methods for FirstName
        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string value)
        {
            FirstName = value;
        }

        // Getter and setter methods for LastName
        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string value)
        {
            LastName = value;
        }

        // Getter and setter methods for PhoneNumber
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(string value)
        {
            PhoneNumber = value;
        }


        // Update Profile Function
        public void UpdateProfile(string password, string email, string firstName, string lastName, string phoneNumber)
        {
            SetPassword(password);
            SetEmail(email);
            SetFirstName(firstName);
            SetLastName(lastName);
            SetPhoneNumber(phoneNumber);
            
        }

    }
}
