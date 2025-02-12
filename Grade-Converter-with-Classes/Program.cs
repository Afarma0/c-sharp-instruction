using ConsoleLibrary;

namespace Grade_Converter_with_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Converter!");
            //while choice = "y"
            string choice = "y";
            while (choice == "y")
            {
                // ** ChangeRequest: Need MyConsole.PromptInt(string prompt, int min, int max)
                int numericGrade = MyConsole.PromptIntWithinRange("Enter numerical grade: ", 0, 100);
                Grade grade = new Grade(numericGrade);
                MyConsole.PrintLine($"Letter grade: {grade.GetLetter()}");
                // ** CR PromptString - validates empty string, y, n
                //while choice = "y"
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n").ToLower();
            }
            
                //prompt numericGrade:int
                //create instance of grade class - pass in numericGrade
                //Print the letterGrade: string
                //prompt try again




            MyConsole.PrintLine("bye");
        }
    }
}
