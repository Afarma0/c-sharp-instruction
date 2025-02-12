using System.Globalization;
using Chap12ClassesDemo;

namespace ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Contact List!");
            string choice = "y";
            while (choice == "y") 
            {
                string FirstName = MyConsole.PromptString("Enter firstname: ");
                string LastName = MyConsole.PromptString("last name: ");
                string Email = MyConsole.PromptString("email: ");
                string Phone = MyConsole.PromptString("phone: ");
                
                Contact c = new Contact(FirstName, LastName, Email, Phone);
                MyConsole.PrintLine(c.DisplayContact());
                //prompt for first name, last name, email, phone#
                //Print full contact info: name (concat 1stN, LastN), email, phone number with gui dashes


                MyConsole.Print("Want more? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            MyConsole.PrintLine("Welcome to Contact List!");
        }
    }
}
