using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager_Inheritance
{
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public Person() { }
        public Person(string Firstname, string LastName)
        {
            this.FirstName = Firstname;
            this.LastName = LastName;

        }

        public string ToString() { return $"Full Name: {FirstName} {LastName}"; }  
    }
}
