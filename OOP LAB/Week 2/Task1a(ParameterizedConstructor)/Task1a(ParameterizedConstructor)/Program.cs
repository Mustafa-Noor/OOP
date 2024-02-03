using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task1a_ParameterizedConstructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mustafa", 1100, 1100, 300, 90);
            Console.WriteLine(s1.sname + "\t" + s1.matricMarks + "\t" + s1.ecatMarks + "\t" + s1.fscMarks + "\t" + s1.aggregate);
            Console.Read();
        }
    }

    class Student
    {
        public Student(string name,float matric,float fsc,float ecat ,float agg)
        {
            sname = name;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            aggregate = agg;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
}
