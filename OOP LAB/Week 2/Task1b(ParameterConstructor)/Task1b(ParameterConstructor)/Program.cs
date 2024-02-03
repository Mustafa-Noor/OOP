using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b_ParameterConstructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mustafa", 1100, 1100, 300, 90);
            Student s2 = new Student("Zain", 1001, 1011, 320, 92);
            Console.WriteLine(s1.sname + "\t" + s1.matricMarks + "\t" + s1.ecatMarks + "\t" + s1.fscMarks + "\t" + s1.aggregate);
            Console.WriteLine(s2.sname + "\t" + s2.matricMarks + "\t" + s2.ecatMarks + "\t" + s2.fscMarks + "\t" + s2.aggregate);
            Console.Read();
        }
    }

    class Student
    {
        public Student(string name, float matric, float fsc, float ecat, float agg)
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
