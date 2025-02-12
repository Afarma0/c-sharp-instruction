namespace ch05hwsolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Continue? (y/n): ");
                Console.WriteLine("Enter miles: ");
                double miles = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter mph: ");
                double mph = double.Parse(Console.ReadLine());
                //totaltime: double = miles/mph
                //hours: int = (int)totaltime
                //minutes: int = (int)((miles % mph) * 60)
                //while choice == y || Y
                //get input: miles, mph
                //biz logic: hours and minutes (whole numbers)
                double totalTime = miles / mph;
                int hours = (int)totalTime;
                double remainder = totalTime - hours;
                int minutes = (int)((remainder) * 60);
                Console.WriteLine("Hours:   " + hours);
                Console.WriteLine("Minutes:   "+ minutes);
                
                //display output
                //prompt continue

                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
        //get input - cents: int
        //biz logic
            //int quarters = (int)(cents / 25)
            //int dimes = (int)((cents - (quarters * 25)) / 10)
            //int nickles = (int)((cents - (quarters * 25) - (dimes * 10)) / 5)
            //int pennies = (int)((cents - (quarters * 25) - (dimes * 10) - (nickles * 5)) / 1)

            string choice1 = "y";
            while (choice1.ToLower() == "y")
            {
                Console.WriteLine("Enter change: ");
                int change = Convert.ToInt32(Console.ReadLine());
                int quarters = (change / 25);
                int dimes = ((change - (quarters * 25)) / 10);
                int nickles = ((change - (quarters * 25) - (dimes * 10)) / 5);
                int pennies = ((change - (quarters * 25) - (dimes * 10) - (nickles * 5)) / 1);
                Console.WriteLine("quarters: " + quarters);
                Console.WriteLine("dimes: " + dimes);
                Console.WriteLine("nickles " + nickles);
                Console.WriteLine("pennies " + pennies);
                Console.WriteLine("Continue? (y/n): ");
                choice1 = Console.ReadLine().ToLower();

            }

                Console.WriteLine("Bye!");
        }
    }
}
