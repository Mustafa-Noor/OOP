using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_DBMS
{
    internal class DegreeProgramBL
    {
        public string DegreeName;
        public float DegreeDuration;
        public List<SubjectBL> Subjects;
        public int Seats;

        public DegreeProgramBL(string DegreeName, float DegreeDuration, int Seats)
        {
            this.DegreeName = DegreeName;
            this.DegreeDuration = DegreeDuration;
            this.Seats = Seats;
            Subjects = new List<SubjectBL>();
        }



    }
}
