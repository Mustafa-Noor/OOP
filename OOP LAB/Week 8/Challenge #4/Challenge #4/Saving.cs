using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge__4
{
    internal class Saving:Account
    {
        private double InterestRate;
        private double MonthlyFee;

        public Saving(string AccountNumber, double balance , double interestRate, double monthlyFee) : base(AccountNumber,balance)
        {
            InterestRate = interestRate;
            MonthlyFee = monthlyFee;
        }
        public double GetInterestRate()
        {
            return InterestRate;
        }

        public void SetInterestRate(double value)
        {
            InterestRate = value;
        }

        public double GetMonthlyFee()
        {
            return MonthlyFee;
        }

        public void SetMonthlyFee(double value)
        {
            MonthlyFee = value;
        }






    }
}
