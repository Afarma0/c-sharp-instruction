using System.Linq.Expressions;
using ConsoleLibrary;

namespace Ch08DemoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyConsole.PrintLine("sorted lists\n");

            //p262
            //create a sortedlist of usStates
            SortedList<string, string> usStates = new SortedList<string, string>();
            usStates.Add("OH", "Ohio");
            usStates.Add("CO", "Colorado");
            usStates.Add("CA", "California");
            usStates.Add("MI", "Michigan");
            

            //get all entries
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.PrintLine($"{entry.Key}:  {entry.Value}");
            }
            //get all keys
            foreach (string s in usStates.Keys)
            {
                MyConsole.Print(s + "|");
            }
            //get all values
            foreach (string s in usStates.Values)
            {
                MyConsole.Print(s + "|");
            }
            //p263 collection initializer
            usStates = new SortedList<string, string>
{
    {"AL", "Alabama"},
    {"AK", "Alaska"},
    {"AZ", "Arizona"},
    {"AR", "Arkansas"},
    {"CA", "California"},
    {"CO", "Colorado"},
    {"CT", "Connecticut"},
    {"DE", "Delaware"},
    {"FL", "Florida"},
    {"GA", "Georgia"},
    {"HI", "Hawaii"},
    {"ID", "Idaho"},
    {"IL", "Illinois"},
    {"IN", "Indiana"},
    {"IA", "Iowa"},
    {"KS", "Kansas"},
    {"KY", "Kentucky"},
    {"LA", "Louisiana"},
    {"ME", "Maine"},
    {"MD", "Maryland"},
    {"MA", "Massachusetts"},
    {"MI", "Michigan"},
    {"MN", "Minnesota"},
    {"MS", "Mississippi"},
    {"MO", "Missouri"},
    {"MT", "Montana"},
    {"NE", "Nebraska"},
    {"NV", "Nevada"},
    {"NH", "New Hampshire"},
    {"NJ", "New Jersey"},
    {"NM", "New Mexico"},
    {"NY", "New York"},
    {"NC", "North Carolina"},
    {"ND", "North Dakota"},
    {"OH", "Ohio"},
    {"OK", "Oklahoma"},
    {"OR", "Oregon"},
    {"PA", "Pennsylvania"},
    {"RI", "Rhode Island"},
    {"SC", "South Carolina"},
    {"SD", "South Dakota"},
    {"TN", "Tennessee"},
    {"TX", "Texas"},
    {"UT", "Utah"},
    {"VT", "Vermont"},
    {"VA", "Virginia"},
    {"WA", "Washington"},
    {"WV", "West Virginia"},
    {"WI", "Wisconsin"},
    {"WY", "Wyoming"}
};

            MyConsole.PrintLine("=== all 50 states ===");
            string sa = "";
            while (sa != "EX")
            {
                sa = MyConsole.PromptString("State Abbrev: ").ToUpper();
                if (sa == "EX") break;
                string sn = "";
                try
                {
                    sn = usStates[sa];
                }
                catch (Exception e)
                {
                    MyConsole.PrintLine($"Error - no state for '{sa}'.");
                    continue;
                }
                
                MyConsole.PrintLine(sn);
            }


            MyConsole.PrintLine("bye");
        }
    }
}
