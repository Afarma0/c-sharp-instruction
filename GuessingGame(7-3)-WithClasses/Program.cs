using ConsoleLibrary;

namespace GuessingGame_7_3__WithClasses
{
    internal class Program
    {
        // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Guessing Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++");
            MyConsole.PrintLine("");

            Game g = new Game();
            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                // play game
                int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;
                MyConsole.PrintLine("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
                //Print("** DEBUG: theNumber = " + theNumber);
                // play game until guess == theNumber
                while (guess != theNumber)
                {
                    guess = MyConsole.PromptInt("Enter number: ");
                    count++;
                    int diff = guess - theNumber;
                    g.diff = diff;
                    g.count = count;
                    g.DisplayGuessMessage();
                }
                // prompt choice
                MyConsole.PrintLine("");
                choice = MyConsole.PromptReqString("Try again? (y/n) ", "y", "n");
                MyConsole.PrintLine("");
            }

            MyConsole.Print("Bye - come back again soon!");
        }             
    }
}