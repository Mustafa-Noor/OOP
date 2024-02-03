using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jason");
            Console.WriteLine(s1.sname);
            Student s2 = new Student("Jack");
            Console.WriteLine(s2.sname);
            Console.Read();
        }
    }

    class Student
    {
        public Student(string name)
        {
            sname = name;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
