using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD5ContactManager
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Contact(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }



        public string DisplayContact()
        {
            string str = "-------------------------\n";
            str += $"First name: {this.FirstName}\n";
            str += $"Last name: {LastName}\n";
            str += $"Email: {Email}";
            return str;
        }
    }
}





