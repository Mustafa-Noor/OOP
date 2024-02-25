using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Task_1.BL;

namespace UAMS_Task_1
{
    internal class DegreeProgramDL
    {
       public static  List<DegreeProgramBL> ProgramList = new List<DegreeProgramBL>();
        public static void AddIntoDegreeList(BL.DegreeProgramBL d)
        {
            ProgramList.Add(d);
        }

        public static void StoreDegreeProgram(string path, DegreeProgramBL d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string SubjectNames = "";
            for (int x = 0; x < d.Subjects.Count - 1; x++)
            {
                SubjectNames = SubjectNames + d.Subjects[x].Type + ";";
            }
            SubjectNames = SubjectNames + d.Subjects[d.Subjects.Count - 1].Type;
            f.WriteLine(d.DegreeName + "," + d.DegreeDuration + "," + d.Seats + "," + SubjectNames);
            f.Flush();
            f.Close();
        }

        public static bool ReadDegreeFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    float degreeDuration = float.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    DegreeProgramBL d = new DegreeProgramBL(degreeName, degreeDuration, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        SubjectBL s = SubjectDL.IsSubjectExists(splittedRecordForSubject[x]);
                        if (s != null)
                        {
                            d.AddSubject(s);
                        }
                    }
                    AddIntoDegreeList(d);
                }
                f.Close();
                return true;
            }
            else
                return false;
        }

        public static DegreeProgramBL IsDegreeExists(string DegreeName)
        {
            foreach(DegreeProgramBL stored in ProgramList)
            {
                if(DegreeName==stored.DegreeName)
                {
                    return stored;
                }
            }

            return null;
        }
    }

    
}
