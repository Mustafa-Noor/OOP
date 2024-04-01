using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionIsU
{
    internal class EmployeeBL : UserBL
    {

        private string Position;

        private string Qualification;

        public EmployeeBL(string username, string password, string email, string firstName, string lastName , string phoneNumber, string role, string position, string qualification) : base(username, password, email, firstName, lastName, phoneNumber, role) 
        {
            
            this.Position = position;
            this.Qualification = qualification;

        }

        public EmployeeBL(UserBL user, string position, string qualification) : base(user)
        {
            this.Position = position;
            this.Qualification = qualification;

        }

        

       

        // Getter and setter methods for Position
        public string GetPosition()
        {
            return Position;
        }

        public void SetPosition(string pos)
        {
            Position = pos;
        }

        // Getter and setter methods for Qualification
        public string GetQualification()
        {
            return Qualification;
        }

        public void SetQualification(string qual)
        {
            Qualification = qual;
        }



    }
}
