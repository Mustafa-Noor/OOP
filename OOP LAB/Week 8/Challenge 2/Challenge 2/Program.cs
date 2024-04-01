using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(1.2, 4, "Grey");

            Console.WriteLine("The Color of the Circle is : " + c.GetColor());
            Console.WriteLine("The Height of the Circle is : " + c.GetHeight());
            Console.WriteLine("The Radius of the Circle is : " + c.GetRadius());

            Console.WriteLine("The area of the Circle is : " + c.GetArea());
            Console.WriteLine("The Volume of the Circle is : " + c.GetVolume());

            Console.Read();
        }
    }
}
