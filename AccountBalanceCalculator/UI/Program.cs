using AccountBalanceCalculator.Model;
using ConsoleLibrary;

namespace AccountBalanceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Account Application!\n");
            MyConsole.PrintLine("Starting Balances");
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance = 1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance = 1000.0m;
            DisplayBalances(ca, sa);
            //initialize checkingACcount, savingsAccount
            //Display Starting Balances
            MyConsole.PrintLine("Enter transactions for the month:\n");
            //while choice == "y"
            string choice = "y";
            while (choice == "y")
            {
                Account a;
                string action = MyConsole.PromptReqString("Withdraw or Deposit? (w/d): ", "w", "d");
                string account = MyConsole.PromptReqString("Checking or Savings (c/s): ", "c", "s");
                decimal amount = MyConsole.PromptDecimal("Amount? ");
                //propmt action: string (w/d)
                //prompt account: string (c/s)
                //prompt amount: decimal

                if (account == "c")
                {
                    a = ca;
                }
                else
                {
                    a = sa;
                }

                if (action == "w")
                {
                    a.Withdraw(amount);
                }
                else
                {
                    a.Deposit(amount);
                }
                //processTransaction




                //prompt continue
                choice = MyConsole.PromptReqString("\nContinue? (y/n)", "y", "n");
            }



            //processEndOfMonth - interest and fees
            //sa => calc interest pmt & add to balnce
            //ca => subtract fee from balance
            sa.ApplyInterestPaymentToBalnce();
            ca.SubtractFeeFromBalance();
            MyConsole.PrintLine("\nMonthly Payments and Fees:");
            MyConsole.PrintLine("Checking Fee " + ca.MonthlyFee.ToString("c"));
            MyConsole.PrintLine("Savings Interest Payment: " + sa.MonthlyInterestPayment.ToString("c"));

            MyConsole.PrintLine("\nFinal Balances: ");
            DisplayBalances(ca, sa);
            //display Final Balances

            //FINIS
        }
        static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            MyConsole.PrintLine($"Checking:   {ca.Balance.ToString("c")}\n Savings:   {sa.Balance.ToString("c")} ");
        }
    }
}

