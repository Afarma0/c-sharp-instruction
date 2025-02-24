using ConsoleLibrary;

namespace SD6CountryListManager
{
    internal class Program
    {
        List<string> countries = new List<string>();
        static void Main(string[] args)
        {

            string command = "";
            while (command != "3")
            {
                DisplayInitialMenu();

                switch (command)
                {
                    case "1":
                        //display countries that have been added
                        break;
                    case "2":
                        //add a country
                        break;
                    case "3":
                        //
                        break;

                }


            }

        private static void DisplayInitialMenu()
        {
            MyConsole.PrintLine("Country List Manager\n");
            MyConsole.PrintLine("COMMAND MENU: Input a number: \n");
            MyConsole.PrintLine("1 (List countries)");
            MyConsole.PrintLine("2 (Add a country)");
            MyConsole.PrintLine("3 (Exit)");
        }
    }
}
