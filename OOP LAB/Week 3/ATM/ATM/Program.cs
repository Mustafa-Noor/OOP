using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ATM------");
            ATM atm = new ATM();
            atm.check_Balance();
            atm.deposit(100);
            atm.deposit(200);
            atm.check_Balance();
            atm.withdrawal(300);
            atm.withdrawal(230);
            atm.check_Balance();
            Console.WriteLine();
            atm.transactionHistory();
            Console.Read();
        }
    }
}
