using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Task_1.BL;

namespace UAMS_Task_1.DL
{
    internal class DegreeProgramDL
    {
       public static  List<DegreeProgramBL> ProgramList = new List<DegreeProgramBL>();
        public static void AddIntoDegreeList(BL.DegreeProgramBL d)
        {
            ProgramList.Add(d);
        }
    }
}
