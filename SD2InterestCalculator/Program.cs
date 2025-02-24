namespace SD2InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator:");

            string choice = "y";
            while (choice == "y")
            {
                double initLoanAmount, interestRate, totalInterestAmount;
                PromptInitVariables(out initLoanAmount, out interestRate);
                //display loan amount, interest rate, interest*
                //*(CALC: initLoanAmount + interestRate 

                totalInterestAmount = CalculateAndDisplayVariables(initLoanAmount, interestRate);

                Console.Write("continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
        }

        private static double CalculateAndDisplayVariables(double initLoanAmount, double interestRate)
        {
            double totalInterestAmount;
            Console.WriteLine();
            Console.WriteLine($"Loan Amount: {initLoanAmount:c}");
            Console.WriteLine($"InterestRate: {interestRate:p}");
            Console.WriteLine($"Interest: {(totalInterestAmount = initLoanAmount * interestRate):c}");
            return totalInterestAmount;
        }

        private static void PromptInitVariables(out double initLoanAmount, out double interestRate)
        {
            Console.WriteLine();
            Console.WriteLine("Enter loan amount: ");
            initLoanAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest rate (decimal value): ");
            interestRate = double.Parse(Console.ReadLine());
            
        }
    }
}
