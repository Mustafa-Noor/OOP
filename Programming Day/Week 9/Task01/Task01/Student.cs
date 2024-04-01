using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Student:Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string Name, string address, string program, int year, double fee) : base(Name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string GetProgram()
        {
            return program;
        }

        public void SetProgram(string value)
        {
            program = value;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int value)
        {
            year = value;
        }

        public double GetFee()
        {
            return fee;
        }

        public void SetFee(double value)
        {
            fee = value;
        }

        public new string toString()
        {
            string result = "Student[" + base.toString() + ", program = " + program + ", year = " + year + ", fee = " + fee + "]";
            return result;
        }

    }
}
