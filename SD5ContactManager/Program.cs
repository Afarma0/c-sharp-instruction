using ConsoleLibrary;

namespace SD5ContactManager
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Contact List");
            string choice = "y";
            while (choice == "y")
            {

                string FirstName = MyConsole.PromptString("FN: ");
                string LastName = MyConsole.PromptString("LN: ");
                string Email = MyConsole.PromptString("EM: ");
                string Phone = MyConsole.PromptString("PN: ");

                Contact c = new Contact(FirstName, LastName, Email, Phone);

                MyConsole.PrintLine(c.DisplayContact());

            }
            MyConsole.PrintLine("Bye");
        }
    }
}
