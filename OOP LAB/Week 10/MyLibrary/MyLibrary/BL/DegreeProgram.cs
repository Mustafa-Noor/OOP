using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.BL
{
    public class DegreeProgram
    {
        public string Title;
        public int Duration;
        public List<Subject> subjects = new List<Subject>();   
        public DegreeProgram()
        {

        }
        public DegreeProgram(string title, int duration)
        {
            Title=title;
            Duration=duration;
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }


    }
}
