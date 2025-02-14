using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager_Inheritance.Model
{
    public class Employee : Person
    {
        string SociNumber { get; set; }
        public Employee() { }
        public Employee(string firstName, string lastName, string sociNumber) :
        base(firstName, lastName)
        {
            this.SociNumber = sociNumber;
        }
        public override string ToString()
        {
            string ssnMasked = "xxx-xx-" + SociNumber.Substring(7);
            return $"{base.ToString()} Social security: {ssnMasked}";
        }
    }
}
