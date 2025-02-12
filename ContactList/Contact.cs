using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class Contact { 
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Contact(string FirstName, string LastName, string Email, string Phone) { 
            this.FirstName = FirstName;
            this.LastName = LastName;   
            this.Email = Email; 
            this.Phone = Phone;

        }
        public string DisplayContact()
        {
            string displayStr = "------------------------------------------\n";
            displayStr += "----------Current Contact-----------------------\n";
            displayStr += "------------------------------------------\n";
            displayStr += $"Name:           {this.FirstName} {this.LastName}\n" ;
            displayStr += $"Email:          {this.Email}\n";
            displayStr += $"Phone:         {this.Phone}\n";
            return displayStr;
        }
    }
}

