using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s  = new Student("2023-CS-17", 1200, "17");
            Saving sa = new Saving("Sas", 120000, 12, 300);
            Checking c = new Checking("123", 2000, 300);

            Console.WriteLine("Student account number : " + s.GetAccountNumber());
            Console.WriteLine("Student Balance : Rs" + s.GetBalance());
            Console.WriteLine("Student id: " + s.GetStudentId());

            Console.WriteLine();

            Console.WriteLine("Saving Account Numvber : " + sa.GetAccountNumber());
            Console.WriteLine("Balance: Rs" + sa.GetBalance());
            Console.WriteLine("Interest Rate: RS" +sa.GetInterestRate());
            Console.WriteLine("Monthly deduction : Rs" + sa.GetMonthlyFee());

            Console.WriteLine();
            Console.WriteLine("Checking account number : " + c.GetAccountNumber());
            Console.WriteLine("Checking Balance : Rs" + c.GetBalance());
            Console.WriteLine("Checking Tax: " + c.GetTax());
            Console.Read();
        }
    }
}
