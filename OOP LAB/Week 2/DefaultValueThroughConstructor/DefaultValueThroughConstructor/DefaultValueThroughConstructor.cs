using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValueThroughConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("The name is {0}, and marks are {1} ",s1.sname, s1.matricMarks);
            Console.ReadKey();
        }



    }

    class Student
    {
        public Student() 
        {
            Console.WriteLine("Constructor Called..");
            sname = "Mustafa";
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
