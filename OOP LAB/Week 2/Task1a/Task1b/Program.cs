using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for(int i=0; i<2; i++)
            {
                students[i] = DeclareConstructor();
                
            }
            DisplayResult(students);
            Console.Read();


        }

        static Student DeclareConstructor()
        {
            Student s = new Student();
            return s;
        }

        static void DisplayResult(Student[] students)
        {
            for(int i=0; i<2; i++)
            {
                Console.WriteLine(students[i].sname + "\t" + students[i].matricMarks + "\t" + students[i].ecatMarks + "\t" + students[i].fscMarks + "\t" + students[i].aggregate);
            }
                    
        }
    }

    class Student
    {
        public Student()
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
