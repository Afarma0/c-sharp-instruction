using System.Xml.Serialization;
using ConsoleLibrary;

namespace Chap16ExDiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DiceRoller!");

            Random rand = new Random();
            string choice = MyConsole.PromptString("Roll the dice? ").ToLower();
            while (choice == "y")
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int total = die1 + die2;
                MyConsole.PrintLine($"Die 1: {die1}\nDie 2: {die2}");
                MyConsole.PrintLine($"Total: {total}\n");

                if (total == 2) {
                    MyConsole.PrintLine("Snake eyes!\n");
                }
                if (total == 12)
                    {
                        MyConsole.PrintLine("box cars!");
                    }
                MyConsole.Print("roll again? (y/n): ");
                Console.ReadLine();


            }











            MyConsole.PrintLine("Bye");

        }
    }
}
