using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a_Calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("Basic Calculator");
            Console.Write("Enter First Number: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            b = float.Parse(Console.ReadLine());

            calculator calculator = new calculator(a,b);
            float sum = calculator.sum();
            float minus = calculator.subtraction();
            float multiply = calculator.multiplication();
            float division = calculator.division();

            Console.WriteLine("Sum is : {0}", sum);
            Console.WriteLine("Subtraction is : {0}", minus);
            Console.WriteLine("Multiplication is: {0}", multiply);
            Console.WriteLine("Division is : {0}", division);
            Console.Read();


        }
    }
}
