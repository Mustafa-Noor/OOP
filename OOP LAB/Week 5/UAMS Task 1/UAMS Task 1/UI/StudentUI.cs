using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Task_1.UI
{
    internal class StudentUI
    {
        public static BL.StudentBL TakeInputForStudent()
        {
            string Name;
            int Age;
            double FSCMarks;
            double EcatMarks;
            List<BL.DegreeProgramBL> Preferences = new List<BL.DegreeProgramBL>();
            Console.Write("Enter Student Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student FSc Marks: ");
            FSCMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            EcatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs");
            UI.DegreeUI.ViewDegreePrograms();

            Console.Write("Enter how many preferences to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            for (int x = 0; x < Count; x++)
            {
                string DegName = Console.ReadLine();
                bool Flag = false;
                foreach (BL.DegreeProgramBL dp in DL.DegreeProgramDL.ProgramList)
                {
                    if (DegName == dp.DegreeName && !(Preferences.Contains(dp)))
                    {
                        Preferences.Add(dp);
                        Flag = true;
                    }
                }

                if (Flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    x--;
                }
            }

            BL.StudentBL s = new BL.StudentBL(Name, Age, FSCMarks, EcatMarks, Preferences);
            return s;
        }

        public static void PrintStduents()
        {
            foreach (BL.StudentBL s in DL.StudentDL.StudentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine(s.Name + " got Admission in " + s.RegDegree.DegreeName);
                }
                else
                {
                    Console.WriteLine(s.Name + " did not get Admission");
                }
            }
        }

        public static void ViewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (BL.StudentBL s in DL.StudentDL.StudentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.Age);
                }
            }
        }

        public static string TakeName()
        {
            Console.Write("Enter the Student Name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        public static void CalculateFeeForAll()
        {
            foreach (BL.StudentBL s in DL.StudentDL.StudentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine(s.Name + " has " + s.CalculateFee() + " fees");
                }
            }
        }

        public static void ViewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (BL.StudentBL s in DL.StudentDL.StudentList)
            {
                if (s.RegDegree != null)
                {
                    if (degName == s.RegDegree.DegreeName)
                    {
                        Console.WriteLine(s.Name + "\t" + s.FSCMarks + "\t" + s.EcatMarks + "\t" + s.Age);
                    }
                }
            }
        }
    }
}
