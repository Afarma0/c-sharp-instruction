using ConsoleLibrary;

namespace AccountBalanceCalcwBrian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Brian!");
            var checkings = new CheckingAccount(1.00);
            var savings = new SavingAccount(1.00);
            checkings.setBalance(1000.00);
            checkings.DepositIntoChecking(200.00);
            MyConsole.PrintLine(checkings.getBalance().ToString());
            savings.setBalance(1000.00);

            //TODO:

            string choice = "y";
            while (choice == "y")
            {
                //prompt for withdrawal or deposit
                    //validate entries to be a w or d // to lower
                //from prompt c/s



                choice = MyConsole.PromptString("Continue (y/n) : ").ToLower();
            }

        }
    }
}
