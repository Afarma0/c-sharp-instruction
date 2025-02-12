using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Grade Converter!");
            //while loop: choice == "y"
            //prompt for input - numericGrade: int
            //do business logic
            // - if/else - convert numeric to letterGrade: string using ranges
            //display result - display letterGrade
            //while loop ends
            String choice = "y";
            while (choice.ToLower() == "y")
            {
                //prompt for input - numericGrade: int
                Console.Write("Enter numeric grade: ");
                int numericGrade = Convert.ToInt32(Console.ReadLine());
                //Int32.Parse
                //business logic
                string letterGrade = "F";
                if (numericGrade >= 88)
                    letterGrade = "A";
                else if (numericGrade >= 80)
                    letterGrade = "B";
                else if (numericGrade >= 68)
                    letterGrade = "C";
                else if (numericGrade >= 60)
                    letterGrade = "D";
                //display result - display letterGrade
                Console.WriteLine("Letter grade: "+ letterGrade);  
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }





                Console.WriteLine("Bye"); 

        }
    }
}
