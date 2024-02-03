using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public float balance=1000;
        public List<string> transaction =new List<string>();
        public void deposit(float value)
        {
            balance += value;
            transaction.Add($"Amount Deposited : {value}");
        }

        public void withdrawal(float value)
        {
            if (value < balance)
            {
                balance -= value;
                transaction.Add($"Amount Withdrawal : {value}");
            }
            else
            {
                Console.WriteLine("Amount Exceeding Balance.");
            }
        }

        public void check_Balance()
        {
            Console.WriteLine("The Current Balance is : {0}", balance);
        }

        public void transactionHistory()
        {
            Console.WriteLine("This is the Transaction History: ");
            for(int i = 0; i<transaction.Count; i++)
            {
                Console.WriteLine(transaction[i]);
            }
        }
    }
}
