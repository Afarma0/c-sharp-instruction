using System;
using System.ComponentModel.Design;

namespace Ch05DemoP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //p. 155
            //while loop, counter and sum
            int i = 0;
            int sum = 0;
            //sum all values from 0 to 10
            while(i<=10)
            {
                sum += i;
                //sum = sum +1;
                i++;
            }
            Console.WriteLine("sum = "+sum);

            //while loop for data validation

            bool success = false;
            int month = 0; 
            //prompt user for month until they enter a valid month
            while (!success)
            {
                Console.WriteLine("Enter month #: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("invalid month number, try again ");
                }
                else
                {
                    success = true;
                }
                Console.WriteLine("Month entered: " +month);
            }

            //while true
            while (true)
            {
                Console.WriteLine("in a while true loop...");
                Console.Write("enter an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0)
                {
                    break;
                }
            }


            //p. 157 for loops
            //0 to 10 sum with for loop
            sum = 0;
            string numberStr = "";
            for (i = 0; i <= 10; i++)
            {
                sum += i;
                numberStr += i + " ";
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = " + sum);

            //0 to 100 by 5
            for (i = 0;i <= 100; i+=5)
            {
                Console.WriteLine("i: "+i);
            }

            //count 99 to 0 by 3
            for (i = 99; i>=0 ; i-=3)
            {
                Console.WriteLine("i: " + i);
            }


            





            Console.WriteLine("Bye!");
        }
    }
}
