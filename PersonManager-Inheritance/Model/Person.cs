using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager_Inheritance.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }

        public virtual string ToString() { return $"Full Name: {FirstName}{LastName}\n"; }
    }
}
