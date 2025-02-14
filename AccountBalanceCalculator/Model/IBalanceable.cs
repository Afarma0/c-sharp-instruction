using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalculator.Model
{
    internal interface IBalanceable
    {
        decimal Balance { get; set; }
    }
}
