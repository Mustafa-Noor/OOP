using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Task_1.BL;

namespace UAMS_Task_1.UI
{
    internal class DegreeUI
    {
        public static void ViewDegreePrograms()
        {
            foreach (BL.DegreeProgramBL dp in DegreeProgramDL.ProgramList)
            {
                Console.WriteLine(dp.DegreeName);
            }
        }

        public static BL.DegreeProgramBL TakeInputForDegree()
        {
            string DegreeName;
            float DegreeDuration;
            int Seats;

            Console.Write("Enter Degree Name: ");
            DegreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            DegreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            Seats = int.Parse(Console.ReadLine());

            BL.DegreeProgramBL degProg = new BL.DegreeProgramBL(DegreeName, DegreeDuration, Seats);
            Console.Write("Enter how many Subjects to Enter: ");
            int Count = int.Parse(Console.ReadLine());
            for (int i = 0; i < Count; i++)
            {
                SubjectBL s = UI.SubjectUI.TakeInputForSubject();
                degProg.AddSubject(s);
                SubjectDL.StoreSubjects("Subject.txt",s);

            }

            return degProg;
        }

        public static string TakeDegree()
        {
            string degName;
            Console.Write("Enter Degree Name: ");
            degName = Console.ReadLine();
            return degName;
        }
    }
}
