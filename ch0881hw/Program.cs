using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace ch0881hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to the Batting Average Calculator!");
            string choice = "y";
            while (choice == "y")
            {
                Print("Enter number of times at bat: ");
                long totalBats = 0;
                totalBats = long.Parse(Console.ReadLine());
                long[] arrayAtBats = new long[totalBats];

                Print("0 = out, 1 = single, 2 = double, 3 = triple, 4 = homerun");
                for (int i = 0; i < totalBats; i++)
                {
                    Console.Write("Result for at-bat " + (i + 1) + ": ");
                    arrayAtBats[(i)] = long.Parse(Console.ReadLine()); 
                    
                }
                long hitCount = 0;
                for (int j = 0; j < arrayAtBats.Length; j++)
                {
                    if (arrayAtBats[j] > 0)
                    {
                        hitCount++;
                    }
                }

                double batAvg =(double)hitCount / arrayAtBats.Length;
                Print("Batter's average: " + batAvg);



                long slugCount = 0;
                for (int k = 0; k < arrayAtBats.Length; k++)
                {
                    if (arrayAtBats[k] > 0)
                    {
                        //not adding up properly
                        slugCount =+  k;
                    }
                }
                double slugAvg = (double)slugCount / arrayAtBats.Length;
                Print("Slugging percent: " + slugAvg);

                //Array.BinarySearch(arrayAtBats, 0);
                //foreach (long 0 in arrayAtBats)
                //    {

                //}
                // ( sum / arrayAtBats.length 
                //while (arrayAtBats[j])
                //long batAvg = 0;
                //if (atbats[] == 0)
                //{

                //}





                //int batAvg = nbr / 

                Print("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Print("thanks");
        }
            
        

        private static void Print(string prompt) { Console.WriteLine(prompt); }
    }
}
