using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace First_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to The Speed Calculator");
            Console.WriteLine("This calculator will calculate the speed...");
            Console.WriteLine("\n");

            Console.Write("Enter the distance in kilometers: ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the time in hours: ");
            double time = double.Parse(Console.ReadLine());

            if (time <= 0)
            {
                Console.Write("The time should be greater than zero.");
                Console.Read();
                return;
            }

            double speed = distance / time;


            Console.WriteLine($"\nDistance: {distance} kilometers" );
            Console.WriteLine($"\nTime: {time} hours");
            Console.WriteLine("\nThe Speed will be {0} in kph", speed);
            Console.Write("\nThank You for using The Speed Calculator!");
            Console.Read();

        }
    }

}

