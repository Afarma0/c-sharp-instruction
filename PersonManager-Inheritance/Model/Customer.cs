using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager_Inheritance.Model
{
    public class Customer : Person

    {
        public string CustNum { get; set; }

        public Customer(string firstName, string lastName, string custNum) :
            base(firstName, lastName)
        {
            this.CustNum = custNum;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Customer Number: {CustNum}";
        }
    }
}
