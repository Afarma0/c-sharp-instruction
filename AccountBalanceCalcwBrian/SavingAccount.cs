using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalcwBrian
{
    public class SavingAccount : Account
    {
        public double MonthlyInterestRate {  get; set; }

        public SavingAccount(double monthlyInterestRate)
        {
            this.MonthlyInterestRate = monthlyInterestRate;
        }
    }
}
