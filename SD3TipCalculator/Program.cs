using ConsoleLibrary;

namespace SD3TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Tip calculator!");

            string choice = "y";
            while (choice == "y")
            {
                decimal costOfMeal;
                GetCalculateAndDisplayTipAndTotalAmounts();
                choice = MyConsole.PromptString("Back for more? (y/n): ").ToLower();
            }
        }
        private static void GetCalculateAndDisplayTipAndTotalAmounts()
        {
            decimal initCostOfMeal = MyConsole.PromptDecimal("Cost of meal: ");                                  
            for (decimal i = 0.15m; i <= 0.25m; i += 0.05m)
            {
                MyConsole.PrintLine($"Tip Percentage: {i:p}\n");
                MyConsole.PrintLine($"Tip Amount: {initCostOfMeal*i:c}\n");
                MyConsole.PrintLine($"Total Amount: {initCostOfMeal + (initCostOfMeal * i):c}\n");
            }

        }
    }
}