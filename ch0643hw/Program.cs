using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ch6_53hw
{
    internal class Program
    {
        //const
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to random number generator");
            Print("++++++++++++++++++++++");
            Print("");
            string choice = "y";
            Random rand = new Random();
            //while choice = 'y'
            //play game
            while (choice == "y") {
                int theNumber = rand.Next(MIN_VAL,MAX_VAL+1);
                //generate random number (theNumber: int)
                int count = 0;
                //count: int = 0
                int guess = 0;
                //play game until guess == theNumber
                Print("I'm thinking of a number from " +MIN_VAL+ " to " +MAX_VAL+ ".\nTry to guess it.\n");
                //Print("** DEBUG: theNumber = " + theNumber);
                while (guess != theNumber)
                {
                    //prompt user to guess(guess: int) & increment count
                    guess = GetNumber("Enter number: ");
                    count++;
                    int diff = guess - theNumber;  
                    if (diff == 0 )
                    {
                        DisplayWinningMessage(count);
                    }
                    else if (diff < -10)
                    {
                        //diff < -10 => way too low
                        Print("way too low, guess again");
                    }
                    else if (diff < 0)
                    {
                        Print("too low, guess again");
                            //diff < 0 => too low
                    }
                    else if (diff > 10)
                    {
                        Print("way too high, guess again");
                        //diff > 10 => way too high
                    }
                    else if (diff > 0)
                    {
                        Print("too high, guess again");
                        //diff > 0 => too high
                    }
                    
                }
                //prompt choice to play again
                Print("");
                choice = GetRequiredString("Try again? (y/n) ", "y", "n");
                Print("");
                }


            Print("Bye");
        }

        static void DisplayWinningMessage(int count)
        {
            
            {
                Print("You got it in " + count + "tries.");
                if (count <= 3)
                {
                    Print("good my child");
                }
                else if (count <= 7) { Print("ok queen"); }
                else if (count > 7) { Print("good job if the goal was failing"); }
                //diff == 0 => win
                //special Msg: count <=3,count <=7, else
            }
        }





        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static string GetRequiredString(string prompt, String val1, string val2)
        {
            string str = "";
            //while true on purpose
            while (true)
            {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "")
                {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2)
                {
                    Print("Error - entry must be either " + val1 + " or " + val2);
                }
                else
                {
                    break;
                }

            }
                return str;

        }
        static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                //was user entry a whole number
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                //catch {
                //    Print("Error entry must be a whole number.");
                //    continue;
                //}
                catch (Exception e)
                {
                    Print("Error entry must be a whole number.");
                    //how to get the content of the thrown exception
                        //Console.Error.WriteLine("e.Message: " + e.Message);
                        //Console.Error.WriteLine("e.ToString(): " + e.ToString());
                    continue;
                }
                
                if (nbr >= MIN_VAL && nbr <= MAX_VAL)
                {
                    success = true;
                }
                else
                {
                    Print("Error entry must be within " +MIN_VAL+" and " +MAX_VAL+".");
                }
                
            }
            return nbr;
        }       
    }
}
