using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student saad = new Student("Saad", "Mandi Bahauddin", "Computer Science", 2023, 4000);
            Staff teacher = new Staff("Azhar", "Mianwali", "DPS", 40000);

            Console.WriteLine("The name of the Student is : " + saad.GetName() ); 
            Console.WriteLine("The city of the Student is : " + saad.GetAddress() );
            Console.WriteLine("The Program of the Student is : " + saad.GetProgram());

            Console.WriteLine();

            Console.WriteLine("The Name of the Staff is : " + teacher.GetName() );
            Console.WriteLine("Address : " + teacher.GetAddress());
            Console.WriteLine("School : " + teacher.GetSchool());
            Console.WriteLine("Pay : " + teacher.GetPay());

            Console.Read();
        }
    }
}
