using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__4
{
    internal class Student:Account
    {
        private string StudentId;

        public Student(string AccountNumber, double balance, string studentId) : base(AccountNumber, balance)
        {
            StudentId = studentId;
        }

        public string GetStudentId()
        {
            return StudentId;
        }

        public void SetStudentId(string value)
        {
            StudentId = value;
        }
    }
}
