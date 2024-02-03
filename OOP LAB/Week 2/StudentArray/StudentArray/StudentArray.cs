using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentsData = new Student[5];
            for (int x=0; x<5; x++)
            {
                studentsData[x] = takeStudentInput();
            }
            printStudentsData(studentsData);
            Console.Read();
        }

        static Student takeStudentInput()
        {
            Student s = new Student();
            Console.Write("Enter Student Name: ");
            s.sname = Console.ReadLine();
            Console.Write("Enter Student Matric Marks: ");
            s.matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            s.fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            s.ecatMarks = float.Parse(Console.ReadLine());
            return s;

        }

        static void printStudentsData(Student[] studentData)
        {
            Console.WriteLine("Name \t MatricMarks \t FscMarks \t EcatMarks");
            for(int x=0; x<5; x++)
            {
                Console.WriteLine(studentData[x].sname + "\t" + studentData[x].matricMarks + "\t" + studentData[x].fscMarks + "\t" + studentData[x].ecatMarks);
            }
        }

    }

    class Student
    {
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
