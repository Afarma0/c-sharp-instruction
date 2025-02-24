using ConsoleLibrary;

namespace SD4DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Dice Roller");
            int die1, die2;
            

            string choice = "y";
            while (choice == "y")
                
            {
                //while loop above
                GenerateRandomRolls(out die1, out die2);
                int total;
                MyConsole.PrintLine($"Die 1: {die1}");
                MyConsole.PrintLine($"Die 2: {die2}");
                MyConsole.PrintLine($"Total: {total = die1 + die2}");

                DisplaySpecialMessage(total);


                choice = MyConsole.PromptReqString("Roll again? (y/n): ", "y", "n").ToLower();
            }
        }

        private static void GenerateRandomRolls(out int die1, out int die2)
        {
            Random rand = new Random();
            die1 = rand.Next(1, 7);
            die2 = rand.Next(1, 7);
        }

        private static void DisplaySpecialMessage(int total)
        {
            if (total == 2)
            {
                MyConsole.PrintLine("\nSnake eyes!");
            }
            if (total == 12)
            {
                MyConsole.PrintLine("\nBoxcars!");
            }
        }

    }
}
