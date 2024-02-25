using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UAMS_Task_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int option;
            do
            {
                option = UI.MainUI.Menu();
                UI.MainUI.ClearScreen();
                if (option == 1)
                {
                    if (DL.DegreeProgramDL.ProgramList.Count > 0)
                    {
                        BL.StudentBL s = UI.StudentUI.TakeInputForStudent();
                        DL.StudentDL.AddIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    BL.DegreeProgramBL d = UI.DegreeUI.TakeInputForDegree();
                    DL.DegreeProgramDL.AddIntoDegreeList(d);
                }

                else if (option == 3)
                {
                    List<BL.StudentBL> SortedStudentList = new List<BL.StudentBL>();
                    SortedStudentList = DL.StudentDL.SortStudentsByMerit();
                    BL.StudentBL.GiveAdmission(SortedStudentList);
                    UI.StudentUI.PrintStduents();
                }

                else if (option == 4)
                {
                    UI.StudentUI.ViewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string DegName = UI.DegreeUI.TakeDegree();
                    UI.StudentUI.ViewStudentInDegree(DegName);
                }
                else if (option == 6)
                {
                    string Name = UI.StudentUI.TakeName();
                    BL.StudentBL s = BL.StudentBL.StudentPresent(Name);
                    if (s != null)
                    {
                        UI.SubjectUI.ViewSubjects(s);
                        UI.SubjectUI.RegisterSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    UI.StudentUI.CalculateFeeForAll();
                }
                UI.MainUI.ClearScreen();
            }
            while (option != 8);
            {
                Console.ReadKey();
            }
        }

    }
}

