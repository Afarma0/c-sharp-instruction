using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalcwBrian
{
    public interface IBalanceable
    {
        double getBalance();
        void setBalance(double amount);
    }
}
