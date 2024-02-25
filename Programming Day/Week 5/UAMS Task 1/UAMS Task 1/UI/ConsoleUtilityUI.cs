using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UAMS_Task_1.UI
{
    internal class ConsoleUtilityUI
    {
        public static void PrintInfoAboutFile(string SubjectPath, string DegreePath, string StudentPath)
        {
            if(SubjectDL.ReadFromFile(SubjectPath))
            {
                Console.WriteLine("Subject Data Loaded Successfully");
                Thread.Sleep(200);
            }
            if(DegreeProgramDL.ReadDegreeFromFile(DegreePath))
            {
                Console.WriteLine("DegreeProgram Data Loaded Successfully");
                Thread.Sleep(200);
            }
            if(StudentDL.ReadStudentsFromFile(StudentPath))
            {
                Console.WriteLine("Student Data Loaded Successfully");
                Thread.Sleep(200);
            }

        }
    }
}
