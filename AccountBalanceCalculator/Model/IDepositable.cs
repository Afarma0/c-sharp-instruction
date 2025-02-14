using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    public interface IDepositable
    {
        public void Deposit(decimal amount);
    }
}
