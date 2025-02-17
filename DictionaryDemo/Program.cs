using ConsoleLibrary;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Dictionary<string, string> usStates = new Dictionary<string, string>();
            //Add - adds an entry, throws exception if already exists
            usStates.Add("OH", "Ohio");
            //[] Indexer sets this position in the dictionary, replaces entry if already exists
            usStates["IN"] = "Indiana";
            MyConsole.PrintLine("Enter states. Enter EX to exit");
            MyConsole.PrintLine("====================================");
            string stateAbbrev = "";
            while (stateAbbrev != "EX")
            {
                stateAbbrev =  MyConsole.PromptString("US STATE ABBREV: ").ToUpper();
                if (stateAbbrev == "EX")
                {
                    break;
                }
                string stateName = MyConsole.PromptString("State Name: ");
                //usStates.Add(stateAbbrev, stateName);
                usStates[stateAbbrev] = stateName;
            }
            MyConsole.PrintLine("Get/Add states:");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");

            MyConsole.PrintLine("Display all keys:");
            
            foreach (string s in usStates.Keys)
            {
                MyConsole.Print(s + ", ");
            }
            //store in a dicitonary

            MyConsole.PrintLine("Display all values:");           
            foreach (string s in usStates.Values)
            {
                MyConsole.Print(s + ", ");
            }

            MyConsole.PrintLine("\nKey Value Pairs: ");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"{entry.Key} - {entry.Value} ");
            }
            MyConsole.PrintLine("");

            MyConsole.PrintLine("Remove an entry: \n");
            usStates.Remove("OH");

            MyConsole.PrintLine(usStates.Keys.ToString());
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"{entry.Key} - {entry.Value} ");
            }
            MyConsole.PrintLine("");

            MyConsole.PrintLine("bye");
        }
    }
}
