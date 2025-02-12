using System.Net.NetworkInformation;

namespace ch0881hwDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the batting averages app!\n");
            string choice = "y";
            while (choice == "y")
            {
                int nbrAtBat = promptInt("Enter number of times at bat: ", 1, 30);
                int[] atBat = new int[nbrAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                for (int i = 0; i < nbrAtBat; i++)
                {
                    //prompt user => result:  int (result for atBat)
                    int result = promptInt("Result for at-bat: " + (i + 1) + ": ", 0, 4);
                    atBat[i] = result;
                    if (result > 0)
                    {
                        countAtBat++;
                    }
                    sumAtBat += result;
                }               
                double battingAvg = (double) countAtBat / nbrAtBat;
                double sluggingPct = (double) sumAtBat / nbrAtBat;
                Print("\nBatting Average: " + battingAvg.ToString("f3"));
                Print("Slugging Percentage: " + sluggingPct.ToString("f3"));
                //display results - formatting: 3 decimal places
                //prompt another player
                Console.Write("Another player? (y/n) ");
                choice = Console.ReadLine().ToLower();
            }


            Print("Goodbye!");
        }

        private static int promptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
               if (Int32.TryParse((Console.ReadLine()), out result))
                {
                    if (result >= min && result <= max)
                    {
                        //if valid - validate in range
                        isValid = true;
                    }
                    else { Print("Error must be within range."); }
                }
                else
                {
                    //if not valid - display a message
                    Print("Error entry must be an integer.");
                }                                              
            }
            return result;
        }
        private static void Print(string message) { Console.WriteLine(message); }
    }
}
