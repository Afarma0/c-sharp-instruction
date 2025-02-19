using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalanceCalcwBrian
{
    public class CheckingAccount : Account
    {
        double  MonthlyFee {  get; set; }

        public CheckingAccount(double monthlyFee) 
        { 
            MonthlyFee = monthlyFee;            
        }
                        
    }
    
}
