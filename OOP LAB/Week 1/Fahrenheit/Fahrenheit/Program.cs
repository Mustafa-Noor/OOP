using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Numbers: ");
            int temp = int.Parse(Console.ReadLine());
            Console.Write("Enter its unit F (Fahrenheit) or C (Celsius): ");
            char unit = char.Parse(Console.ReadLine());

            int newTemp;
            if(unit=='F')
            {
                newTemp = (temp - 32) * (5 / 9);
                Console.WriteLine($"The temperature is {0} in Celsius.", newTemp);
                Console.Read();
            }
            else if (unit=='C')
            {
                newTemp = (temp * (9 / 5))+ 32;
                Console.WriteLine($"The temperature is {newTemp} in Fahrenheit.");
                Console.Read();
            }

            
        }
    }
}
