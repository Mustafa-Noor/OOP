using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.sname = "Jack";
            Student s2 = new Student(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.Read();
        }
    }

    class Student
    {
        public Student()
        {
            Console.WriteLine("This is Default Constructor..");
        }
        public Student(Student s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
