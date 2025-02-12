using System.Text;

namespace ch09Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           newLine("Welcome to strings and dates!");


            //p. 275 what's the current date and time
            DateTime currentDateTime = DateTime.Now;
            //what's the current date
            DateTime today = DateTime.Today;


            newLine("Current date = " + currentDateTime + ".");
                //concatenation^^^

            newLine($"Today = {today}. ");
            //string interpolation


            //p.277
            newLine($"longDate: {currentDateTime.ToLongDateString()}");
            newLine($"longTime: {currentDateTime.ToLongTimeString()}");
            newLine($"shortDate: {currentDateTime.ToShortDateString()}");
            newLine($"shortTime: {currentDateTime.ToShortTimeString()}");

            //p.279 get information about a date
            newLine($"Month: {currentDateTime.Month}");
            newLine($"Day: {currentDateTime.Day}");
            newLine($"DayOfWeek: {currentDateTime.DayOfWeek}");
            newLine($"DayOfYear: {currentDateTime.DayOfYear}");
            //Year
            newLine($"Days in month - 2025, 2: {DateTime.DaysInMonth(2025, 2)}");
            //IsLeapYear

            //p. 281
            //due date in 2 months:
            DateTime dueDate = currentDateTime.AddMonths(2);
            newLine($"dueDate: {dueDate}");

            //Halloween 2025
            DateTime halloween = new DateTime(2025, 10, 31);
            newLine($"halloween: {halloween}");

            newLine($"halloween > today? {halloween > currentDateTime}");
            //you can compare dates like integers, with a later date being GREATER than an earlier one
            TimeSpan timeTilHallo = halloween.Subtract(currentDateTime);
                //calculate the difference
            newLine($"Days until halloween: {timeTilHallo.Days}");
            //specifying the time variable -- days     ^^minutes months etc

            //strings - p. 285
            //loop thru characters in a string
            string sentence = "Woohoo!";
            foreach (char c in sentence)
            {
                sameLine(c + " ");
            }
            newLine("");

            //hangman - creating an underscore version of a word
            //word is "superman", the hiddenVersion would be "_ _ _ _ _ _ _ _"
            string word = "superman";
            string hiddenVersion = "";
            foreach (char c in word)
            {
                hiddenVersion += "_ ";
            }
            hiddenVersion = hiddenVersion.Trim();
            newLine($"the word is {word}.");
            newLine($"the hiddenVersion is {hiddenVersion}.");
                
            //p. 293
            //strings are immutable -- unable to be changed (new ones are created when you manipulate one like in lines 
            //69 and 71

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", how ");
            sb.Append("are you");
            newLine(sb.ToString());






            newLine("bye");
        }




        static void sameLine(string msg) { Console.Write(msg); }
        static void newLine(string msg) { Console.WriteLine(msg); }
    }
}
