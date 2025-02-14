using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    internal class SavingsAccount : Account
    {
        public decimal MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }

        public SavingsAccount(decimal monthlyInterestRate)
        {
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public void ApplyInterestPaymentToBalnce()
        {
            MonthlyInterestPayment = Balance * MonthlyInterestRate;
            Balance += MonthlyInterestPayment;
        }
    }
}
