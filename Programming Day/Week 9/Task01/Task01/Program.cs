using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Mustafa", "Gulberg", "Computer Science", 2023, 12000);
            Staff st = new Staff("ABC", "Garden Town", "UET", 2100.00);

            Console.WriteLine( s.toString());
            Console.WriteLine( st.toString());
            Console.Read();
        }
    }
}
