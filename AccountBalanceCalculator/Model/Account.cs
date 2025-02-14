using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    internal class Account : IBalanceable, IDepositable, IWithdrawable
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
