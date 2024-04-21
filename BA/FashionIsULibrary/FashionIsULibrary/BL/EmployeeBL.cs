using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    public class EmployeeBL : UserBL
    {

        
        public EmployeeBL(string username, string password, string email, string firstName, string lastName , string phoneNumber, string role) : base(username, password, email, firstName, lastName, phoneNumber, role) 
        {
            

        }

        public EmployeeBL(string username, string password) : base(username, password) { }

        public EmployeeBL(UserBL user) : base(user)
        {
            

        }

        




    }
}
