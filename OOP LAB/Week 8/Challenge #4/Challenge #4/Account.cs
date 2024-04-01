using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__4
{
    internal class Account
    {
        private string AccountNumber;
        private double Balance;

        public Account(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void SetBalance(double balance)
        { this.Balance = balance; }

        public void SetAccountNumber(string AccountNumber)
        { this.AccountNumber = AccountNumber; }


    }
}
