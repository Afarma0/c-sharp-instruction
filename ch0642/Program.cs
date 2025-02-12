using System.Runtime.CompilerServices;

namespace ch0642
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("go");
            string choice = "y";
            while (choice == "y")
            {
                //get input theNumber: long
                long theNumber = GetLong("Enter an integer that's greater than 0 and less than 1000: ", 1, 1000);
                //compute the factorial w/for loop - factorial: long
                //for i = 1, i <= theNumber, i++ => factorial = factorial * i
                long theFactorial = 1;
                       //starts at 1 to not mess up multiplication
                for (int i = 1; i <= theNumber; i++)
                {
                    //theFactorial = theFactorial * i;
                    theFactorial *= i;
                }
                Print("The factorial of " + theNumber + " is " + theFactorial + ".");


                //
                Console.WriteLine("Continue? (y/n) ");
                choice = Console.ReadLine().ToLower();
            }

            

            //while - choice
                //get input theNumber: long
                //-0 <theNumber < 10
                //compute the factorial w/for loop - factorial: long
                //for i = 1, i <= theNumber, i++ => factorial = factorial * i
            Print("Bye");
        }


        private static long GetLong(string prompt, long min, long max)
        {
            long result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result))
                {
                    Print("Error invalid whole number. Try again.");
                    continue;
                }
                if (result < min || result > max)
                {
                    Print("Error input must be within range (" + min + "-" + max + ") Try again.");
                }
                else
                {
                    isValid = true;
                }
            }
            return result;
        }
        //
        static void Print(string prompt)
        { Console.WriteLine(prompt); }
    }
}
