using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UAMS_Task_1.BL;

namespace UAMS_Task_1
{
    internal class SubjectDL
    {
        public static List <SubjectBL> AllSubjects = new List <SubjectBL>();

        public static void StoreSubjects(string path, SubjectBL s)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s.Code + "," + s.Type + "," + s.CreditHours + "," + s.SubjectFees);
            file.Flush();
            file.Close();
        }

        public static bool ReadFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    SubjectBL s = new SubjectBL(code, type, creditHours, subjectFees);
                    AddSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddSubjectIntoList(SubjectBL s)
        {

            AllSubjects.Add(s);
        }

        public static SubjectBL IsSubjectExists(string Name)
        {
            foreach(SubjectBL stored in AllSubjects)
            {
                if(Name==stored.Type)
                {
                    return stored;
                }
            }

            return null;
        }


    }
}
