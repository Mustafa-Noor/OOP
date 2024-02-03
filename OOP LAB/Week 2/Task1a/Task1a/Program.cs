using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            displayOfData(s1);
            Console.Read();
            

        }

        static void displayOfData(Student s1)
        {
            Console.WriteLine("Name will be : {0} ", s1.sname);
            Console.WriteLine("Marks in Matric will be : {0}", s1.matricMarks);
            Console.WriteLine("Marks in fsc will be: {0}", s1.fscMarks);
            Console.WriteLine("Marks in ecat will be: {0}", s1.ecatMarks);
        }
    }

    class Student
    {
        public Student () 
        {
            sname = "Mustafa";
            matricMarks = 1100;
            fscMarks = 1100;
            ecatMarks = 400;
            aggregate = 99.9F;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
