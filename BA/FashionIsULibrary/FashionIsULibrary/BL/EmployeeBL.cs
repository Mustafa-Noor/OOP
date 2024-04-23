using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class EmployeeBL : UserBL
    {
        private string Position; // attribute of postion

        // Parameterized constructors
        public EmployeeBL(string username, string password, string email, string firstName, string lastName , string phoneNumber, string role, string position) : base(username, password, email, firstName, lastName, phoneNumber, role) 
        {
            this.Position = position;
        }

        public EmployeeBL(string username, string password) : base(username, password) { }

        public EmployeeBL(UserBL user, string position) : base(user)
        {
            this.Position = position;
        }

        public EmployeeBL(EmployeeBL emp): base(emp)
        {
            this.Position= emp.Position;
        }

        //Getter and Setter
        public string GetPosition()
        {
            return this.Position;
        }

        public void SetPosition(string postion)
        {
            this.Position = postion;
        }

        // Updates The Profile Of Customer
        public void UpdateProfile(EmployeeBL emp)
        {
            this.Position = emp.Position;
            SetPassword(emp.Password);
            SetEmail(emp.Email);
            SetFirstName(emp.FirstName);
            SetLastName(emp.LastName);

        }
    }
}
