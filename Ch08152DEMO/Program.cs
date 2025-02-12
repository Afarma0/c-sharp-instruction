namespace Ch081502WIZARD
{
    internal class Program
    {
        static List<string> items = new List<string>();

        static void Main(string[] args)
        {
            newLine("Hello, Merlin!");
            List<string> items = new List<string>();
            string command = "";
            while (command != "exit")
            {
                DisplayMenu();
                sameLine("Command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "show":

                        ShowItems();
                        break;

                    case "grab":
                        newLine("Grab/Add an Item");
                        newLine("---------------");
                        GrabItem();
                        break;

                    case "edit":
                        newLine("Edit an Item");
                        newLine("---------------");
                        GrabItem();
                        break;

                    case "drop":
                        newLine("Drop an Item");
                        newLine("---------------");
                        DropItem();
                        break;

                    case "exit":
                        break;
                }
            }

            //while loop
            //display menu
            //prompt command
            //evaluate command
            //stop loop? command == "exit"



            newLine("Bye Merlin.");
        }

        private static void DropItem()
        {
            throw new NotImplementedException();
        }

        private static void GrabItem()
        {
            throw new NotImplementedException();
            newLine("Grab/Add an Item");
            newLine("---------------");
        }

        private static void ShowItems()
        {
            newLine("Show all items:");
            newLine("---------------");
            for (int i = 0; i <= items.Count; i++)
            {
                newLine($"{i + 1}. {}");
            }

            static void DisplayMenu()
            {
                newLine("Command menu: \n");
                newLine("show - show all items: ");
                newLine("grab - grab/add an item ");
                newLine("edit - edit an item ");
                newLine("drop - drop an item ");
                newLine("exit - exit an item ");

            }

            static int PromptInt(string prompt, int min, int max)
            {
                int result = 0;
                bool IsValid = false;
                while (IsValid == false)
                {
                    sameLine(prompt);
                    if (Int32.TryParse(Console.ReadLine(), out result))
                    {
                        if (result >= min && result <= max)
                        {
                            IsValid = true;
                        }
                        else
                        {
                            newLine(" Error - entry must be within range");
                        }
                    }
                    else
                    {
                        newLine("Error - entry must be a whole number.");
                    }


                    return result;
                }
            }
            static void newLine(string msg) { Console.WriteLine(msg); }
            static void sameLine(string msg) { Console.Write(msg); }
        }
    }
}
