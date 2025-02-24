using System.Security.Cryptography;
using ConsoleLibrary;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Knowledge assessment.");

            int number1 = 1;
            int number2 = 2;

            int sumTotal = GetSum(number1, number2);
            MyConsole.PrintLine(sumTotal.ToString());

            List<double> prices = new List<double>() { 11.99, 24.99, 2.25, 9.99 };
            foreach (double price in prices)
            {
                Console.Write($"{price}|");
            }

            
            double total = 0;
            foreach (double p in prices)
            {
                total += p;
                
            }
            double avg = total / prices.Count;


        }
        private static int GetSum(int n1, int n2)
        {
            return n1 + n2;

        }
    }
}
