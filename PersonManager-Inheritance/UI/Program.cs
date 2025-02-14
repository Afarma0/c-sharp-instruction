using ConsoleLibrary;
using PersonManager_Inheritance.Model;

namespace PersonManager_Inheritance.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person Manager!");
            string choice = "y";
            while (choice == "y")
            {
                string personType = MyConsole.PromptReqString("Create customer or employee? (c/e):", "c", "e").ToLower();
                string firstName = MyConsole.PromptString("First name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                Person p;
                if (personType == "c")
                {
                    string custNum = MyConsole.PromptString("Customer number:  ");
                    Customer c = new Customer(firstName, lastName, custNum);
                    p = c;
                }
                else 
                {
                    string ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p = e;
                }
                MyConsole.PrintLine("");
                MyConsole.PrintLine("You entered a new " + p.GetType().Name + ":");
                MyConsole.PrintLine(p.ToString());


                choice = MyConsole.PromptReqString("continue? (y/n) : ", "y", "n").ToLower();
            }







            MyConsole.PrintLine("Bye!");
        }
    }
}
