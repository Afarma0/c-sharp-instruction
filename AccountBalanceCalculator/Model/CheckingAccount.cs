using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    internal class CheckingAccount : Account
    {
        public decimal MonthlyFee { get; set; }

        public CheckingAccount(decimal monthlyFee) {
            MonthlyFee = monthlyFee;
                }

        public void SubtractFeeFromBalance()
        {
            Balance -= MonthlyFee;
        }
    }
}
