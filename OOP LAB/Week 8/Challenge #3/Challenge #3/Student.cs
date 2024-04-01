using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__3
{
    internal class Student: Person
    {
        private string Program;
        private int Year;
        private double Fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public string GetProgram()
        {
            return Program;
        }

        public void SetProgram(string value)
        {
            Program = value;
        }

        public int GetYear()
        {
            return Year;
        }

        public void SetYear(int value)
        {
            Year = value;
        }

        public double GetFee()
        {
            return Fee;
        }

        public void SetFee(double value)
        {
            Fee = value;
        }

    }
}
