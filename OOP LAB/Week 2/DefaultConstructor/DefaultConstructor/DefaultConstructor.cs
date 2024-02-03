using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.Read();
        }
    }

    class Student
    {
        public Student() 
        {
            Console.WriteLine("Default Constructor Called...");
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
