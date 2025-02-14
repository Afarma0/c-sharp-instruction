using System.ComponentModel.DataAnnotations;
using ConsoleLibrary;

namespace Pig_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Hola pig");
            string choice = "y";
            while (choice == "y")
            {
                int nbrGames = MyConsole.PromptInt("Number of games to play? ");
                int highScore = 0;
                int highScoreNumRolls = 0;
                for (int i = 0; i < nbrGames; i++)
                {
                    int rollCount = 0;
                    int roll = 0;
                    int score = 0;
                    while (roll != 1)
                    {
                        rollCount++;
                        roll = rand.Next(1, 7);
                        if (roll != 1)
                        {
                            score += roll;
                        }
                    }
                    //highScore = (score > highScore) ? score : highScore;
                    if (score > highScore)
                    {
                        highScore = score;
                        highScoreNumRolls = rollCount;

                    }
                    MyConsole.PrintLine("High score was " + highScore);
                    MyConsole.PrintLine("High rolls were " + highScoreNumRolls);
                    choice = MyConsole.PromptReqString("Again? (y/n): ", "y", "n");
                    //compound way to do an if statement
                }
            }
                //while choice
                //prompt nbrGames:int
                //highScore = 0
                //for i<=nbr Games
                //play game --> roll dice until a 1 is rolled
                //store score, compare to highScore
                //display highScore
                //prompt again


                MyConsole.PrintLine("Bye pig");
            
        }
    }

