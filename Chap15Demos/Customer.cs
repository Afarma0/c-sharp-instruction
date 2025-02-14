using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Demos
{
    internal class Customer : Summarizable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustNum { get; set; }

        public Customer(string firstName, string lastName, string custNum)
        {
            FirstName = firstName;
            LastName = lastName;
            CustNum = custNum;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Customer: ({CustNum}) ({LastName}) {FirstName}";
            return summary;
        }
    }
}
