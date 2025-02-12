using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ch6_41hw
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //initial msg/linebreak
            Print("go");
            Print("");            
                        
            string choice = "y";
            while (choice == "y")
            {
                int n = 0;
                int i = 1;
                n = GetNumber("Enter number: ");
                Print("Number\t squared\t cubed");
                Print("======\t =======\t =====");
                while (i <= n)
                {
                    //print number, square, and cube incrementing                   
                    Print(i  + "\t" + (i * i) + "\t" + (i * i * i));
                    i++;
                }
                Print("Continue? (y/n): ");
                choice = Console.ReadLine();
            }            
        }

















        private static void Print(string prompt)
        { Console.WriteLine(prompt); }




        static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                //was user entry a whole number
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                    success = true;
                }

                //catch {
                //    Print("Error entry must be a whole number.");
                //    continue;
                //}
                catch (Exception e)
                {
                    Print("Error entry must be a whole number.");
                    //how to get the content of the thrown exception
                    //Console.Error.WriteLine("e.Message: " + e.Message);
                    //Console.Error.WriteLine("e.ToString(): " + e.ToString());
                    continue;
                }             
            }
            return nbr;
        }
    }
}
