using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a_Calculator_
{
    internal class calculator
    {
        public calculator(float num1, float num2 ) 
        {
            a=num1;
            b=num2;
        }
        public float a;
        public float b;
       
        public float sum()
        {
            return a + b;
        }

        public float subtraction()
        {
            return b - a;
        }

        public float multiplication()
        { return a * b; }

        public float division()
        {
            return a / b;
        }
    }
}
