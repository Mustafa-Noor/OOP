using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_DBMS
{
    internal class StudentBL
    {
        public string RollNumber;
        public string Name;
        public int Age;
        public double FSCMarks;
        public double EcatMarks;
        public double Merit;
        public List<DegreeProgramBL> Preferences;
        public List<SubjectBL> RegSubject;
        public DegreeProgramBL RegDegree;

        public StudentBL(string Name, int Age, double FSCMarks, double EcatMarks, List<DegreeProgramBL> Preferences)
        {
            this.Name = Name;
            this.Age = Age;
            this.FSCMarks = FSCMarks;
            this.EcatMarks = EcatMarks;
            this.Preferences = Preferences;
            RegSubject = new List<SubjectBL>();

        }
    }
}
