using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Task_1.BL;
using UAMS_Task_1.UI;

namespace UAMS_Task_1
{
    internal class StudentDL
    {
        public static List<StudentBL> StudentList = new List<StudentBL>();

        public static void AddIntoStudentList(StudentBL s)
        {
            StudentList.Add(s);
        }

        public static List<BL.StudentBL> SortStudentsByMerit()
        {
            List<BL.StudentBL> sortedStudentList = new List<BL.StudentBL>();
            foreach (BL.StudentBL s in StudentDL.StudentList)
            {
                s.CalculateMerit();
            }

            sortedStudentList = StudentList.OrderByDescending(o => o.Merit).ToList();
            return sortedStudentList;
        }

        public static void StoreStudentToFile(string path, StudentBL s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string DegreeNames = "";
            for (int x = 0; x < s.Preferences.Count - 1; x++)
            {
                DegreeNames = DegreeNames + s.Preferences[x].DegreeName + ";";
            }
            DegreeNames = DegreeNames + s.Preferences[s.Preferences.Count - 1].DegreeName;
            f.WriteLine(s.Name + "," + s.Age + "," + s.FSCMarks + "," + s.EcatMarks + "," + DegreeNames);
            f.Flush();
            f.Close();
        }

        public static bool ReadStudentsFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    string Name = SplittedRecord[0];
                    int Age = int.Parse(SplittedRecord[1]);
                    double FSCMarks = double.Parse(SplittedRecord[2]);
                    double EcatMarks = double.Parse(SplittedRecord[3]);
                    string[] SplittedRecordForPreference = SplittedRecord[4].Split(';');
                    List<DegreeProgramBL> Preferences = new List<DegreeProgramBL>();
                    for (int x = 0; x < SplittedRecordForPreference.Length; x++)
                    {
                        DegreeProgramBL d = DegreeProgramDL.IsDegreeExists(SplittedRecordForPreference[x]);
                        if (d != null)
                        {
                            if (!(Preferences.Contains(d)))
                                Preferences.Add(d);
                        }
                    }
                    StudentBL s = new StudentBL(Name, Age, FSCMarks, EcatMarks, Preferences);
                    StudentList.Add(s);
                }
                f.Close();
                return true;
            }
            else
                return false;
        }

        
    }
}
