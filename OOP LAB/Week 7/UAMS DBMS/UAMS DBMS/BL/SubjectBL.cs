using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_DBMS
{
    internal class SubjectBL
    {
        public int Code;
        public string Type;
        public int CreditHours;
        public int SubjectFees;

        public SubjectBL(int Code, string Type, int CreditHours, int SubjectFees)

        {

            this.Code = Code;
            this.Type = Type;
            this.CreditHours = CreditHours;
            this.SubjectFees = SubjectFees;

        }

    }
}
