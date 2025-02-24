using ConsoleLibrary;

namespace Batting_Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome");
            string choice = "y";
            while (choice == "y") {

                int timesAtBat = MyConsole.PromptInt("Enter number of times at bat: ");

                int[] arrayTimesAtBat = new int[timesAtBat];

                MyConsole.PrintLine("0 = Out, 1 = Single, 2 = Double, 3 = Triple, 4 = Home Run");

                for (int i = 0; i < timesAtBat; i++)
                {

                }






            MyConsole.PrintLine("Bye");
        }
    }
}
