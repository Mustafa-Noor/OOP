using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.BL
{
    public class Student
    {
        public int Roll;
        public string Name;
        public float Ecat;
        public float Matric;
        public float FSc;
        public DegreeProgram DegreeProgram;
        public List<Subject> RegisteredSubjects = new List<Subject>();
        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();

        public Student(int roll, string name, float ecat, float matric, float fsc)
        {
            Roll = roll;
            Name = name;
            Ecat = ecat;
            Matric = matric;
            FSc = fsc;
        }
    }
}
