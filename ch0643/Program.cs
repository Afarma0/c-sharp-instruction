namespace ch0643
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Cost of meal: ");
                decimal costOfMeal = Decimal.Parse(Console.ReadLine());
                    //skipped validation
                //biz logic:
                    //calculate and display tipAmt and totalAmt: decimals for .15, .20, .25
                        //for decimal d = .15m; d<=.25m; d+=.05
                for (decimal d = .15m; d<=.25m; d+=.05m)

                {
                    decimal tipAmt = costOfMeal * d;
                    decimal totalAmt = costOfMeal + tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("tip amt: " + tipAmt.ToString("c"));
                    Console.WriteLine("tot amt: " + totalAmt.ToString("c"));
                    Console.WriteLine();
                }
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
        }
    }
}