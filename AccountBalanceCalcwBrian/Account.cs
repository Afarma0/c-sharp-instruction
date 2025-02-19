


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalcwBrian
{
    public class Account : IWithdrawable, IBalanceable, IDepositable
    {
        private double balance {  get; set; }
        public void deposit(double amount)
        {
            balance += amount;
        }

        public double getBalance()
        {
           return balance;
        }

        public void setBalance(double amount)
        {
            balance = amount;
        }

        public void withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
