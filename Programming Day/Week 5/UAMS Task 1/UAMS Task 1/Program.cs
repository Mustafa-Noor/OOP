using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAMS_Task_1.BL;
using UAMS_Task_1.UI;

namespace UAMS_Task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string SubjectPath = "Subject.txt";
            string DegreePath = "DegreeProgram.txt";
            string StudentPath = "Student.txt";

            ConsoleUtilityUI.PrintInfoAboutFile(SubjectPath, DegreePath, StudentPath);
            Console.Clear();

            int option;
            do
            {
                

                option = MainUI.Menu();
                MainUI.ClearScreen();
                if (option == 1)
                {
                    if (DegreeProgramDL.ProgramList.Count > 0)
                    {
                        StudentBL s = StudentUI.TakeInputForStudent();
                        StudentDL.AddIntoStudentList(s);
                        StudentDL.StoreStudentToFile(StudentPath, s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgramBL d = DegreeUI.TakeInputForDegree();
                    DegreeProgramDL.AddIntoDegreeList(d);
                    DegreeProgramDL.StoreDegreeProgram(DegreePath, d);

                }

                else if (option == 3)
                {
                    List<StudentBL> SortedStudentList = new List<StudentBL>();
                    SortedStudentList = StudentDL.SortStudentsByMerit();
                    StudentBL.GiveAdmission(SortedStudentList);
                    StudentUI.PrintStduents();
                }

                else if (option == 4)
                {
                    StudentUI.ViewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string DegName = DegreeUI.TakeDegree();
                    StudentUI.ViewStudentInDegree(DegName);
                }
                else if (option == 6)
                {
                    string Name = StudentUI.TakeName();
                    StudentBL s = BL.StudentBL.StudentPresent(Name);
                    if (s != null)
                    {
                        SubjectUI.ViewSubjects(s);
                        SubjectUI.RegisterSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    StudentUI.CalculateFeeForAll();
                }
                MainUI.ClearScreen();
            }
            while (option != 8);
            {
                Console.ReadKey();
            }
        }

    }
}

