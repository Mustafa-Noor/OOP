using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.BL
{
    public class Subject
    {
        public string Title;
        public int Code;
        public int CreditHours;
        public int Fee;
        
        public Subject() { }
        public Subject(string title, int credithours, int fee)
        {
            this.Title = title;
            this.CreditHours = credithours;
            this.Fee = fee;
        }
    }
}
