using System.Runtime.CompilerServices;
using System.Transactions;

namespace GradeConverterReviewSolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Converter");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter numerical grade: ");
                CalcReturnPrintLetterGrade(int.Parse(Console.ReadLine()));
                Console.WriteLine("continue? (y/n): ");
                choice = Console.ReadLine();
                //.ToLower ??
            }

        }

        private static string CalcReturnPrintLetterGrade(int nbrGrade)
        {
            string lettergrade = "";

            //Console.WriteLine("Enter numerical grade: ");
            //nbrGrade = int.Parse(Console.ReadLine());
            lettergrade = ("Letter Grade: ");
            if (nbrGrade >= 88)
            {
                lettergrade += ("A");
            }
            else if (nbrGrade >= 80)
            {
                lettergrade += ("B");
            }
            else if (nbrGrade >= 67)
            {

                lettergrade += ("C");
            }
            else if (nbrGrade >= 60)
            {
                lettergrade += ("D");
            }
            else
            {
                lettergrade += ("F");
            }
            Console.WriteLine(lettergrade);
            return lettergrade;
        }
    }
}

