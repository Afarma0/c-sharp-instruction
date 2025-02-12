namespace Ch05HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ////nearest whole number rounded down
            //Console.WriteLine("number: ")

            

            //3.1--convert Fahrenheit to Celsius
            string choice = "y";
            while (choice.ToLower() == "y")
            { 
            Console.WriteLine("Enter temp in Fahrenheit: ");
            double tempF = Convert.ToDouble(Console.ReadLine());
            double tempC = 0.0;
            tempC = ((tempF - 32) * 5 / 9);
            Console.WriteLine("Temperature in Celsius " + (Math.Round(tempC, 2)));
                Console.WriteLine("continue? (y/n): ");
               choice = Console.ReadLine();
            }
            //3.2 calculates travel based on distance and speed
            string choice1 = "y";
            while (choice1.ToLower() == "y")
            {
                Console.WriteLine("Enter miles: ");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter mph: ");
                double mph = Convert.ToDouble(Console.ReadLine());  
                double timeHours = miles / mph;
                int timeMinutes = (int)(timeHours * 60);
                int hoursInt = timeMinutes / 60;
                timeMinutes = timeMinutes % 60;
                //timeMinutes = timeMinutes % 1
                Console.WriteLine("Estimated travel time: ");
                Console.WriteLine("_______________________");
                Console.WriteLine("Hours:\n "+hoursInt);
                Console.WriteLine("Minutes: " + timeMinutes);
                Console.WriteLine("continue? (y/n): ");
                choice1 = Console.ReadLine();

            }
            //3.3
            decimal price = 37546.78567m;
            decimal interestRate = .03789345m;

            Console.WriteLine("price: " + price.ToString("c"));
            Console.WriteLine("interestRate: " + interestRate.ToString("p3"));

            string choice2 = "y";
            while (choice2.ToLower() == "y")
            {
            Console.WriteLine("Enter loan amount: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            double interest = price * interestRate;



            //print results/summary
            Console.WriteLine("price: " + price.ToString("c"));
            Console.WriteLine("interestRate: " + interestRate.ToString("p3"));
            Console.WriteLine("Interest:            "+interest);
            //prompt for user repeat
            Console.WriteLine("Continue? (y/n):  ");
            choice2 = Console.ReadLine(); 

            }
            //3.4 your change

            Console.WriteLine("Enter number of cents (0-99) :  ");
            int total = Convert.ToInt32(Console.ReadLine());
            if
            {
                total => 25;
            then 
            }   

            


            Console.WriteLine("Bye");
        }
    }
}
