using System;
using System.Text;
using Microsoft.VisualBasic;

namespace Ch0915_2hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            newLine("Welcome to the wizard game\n");
            

            List<string> items = new List<string>();
            items.Add("a");
            items.Add("b");
            items.Add("c");

            int maxItems = 4;
            

            newLine("COMMAND MENU:\n");
            newLine("show - Show all your items");
            newLine("grab - Grab an item");
            newLine("edit - Edit an item");
            newLine("drop - Drop an item");
            newLine("exit - Exit program\n ");

            string action = "";
            while (action != "exit")            
            {
               sameLine("Command: ");

                               
                action = Console.ReadLine().ToLower();
                switch (action)
                {
                    case "show":
                        
                        for (int i = 0; i < items.Count; i++)
                        {                            
                            Console.WriteLine($"{i+1}: {items[i]}");
                            //newLine($"item {n+1}: {items}");
                        }
                        break;
                    case "grab":
                        if (items.Count >= maxItems)
                        {
                            newLine("Error: You can only hold up to 4 items. Cannot grab more.");
                        }
                        else
                        {
                            sameLine("Name: ");
                            string grabbedItem = Console.ReadLine();
                            items.Add(grabbedItem);
                            /*newLine($"{items.Add(Console.ReadLine())} was added.")*/
                        }
                        break;
                    case "edit":
                        // Prompt user for the number corresponding to the item they want to edit
                        sameLine("Number: ");
                        int position;
                        if (int.TryParse(Console.ReadLine(), out position) && position >= 0 && position < items.Count)
                        {
                            // Prompt for the updated name
                            newLine("Updated name: ");
                            string updatedName = Console.ReadLine();

                            // Update the item in the list at the specified position (adjust for 0-based index)
                            items[position] = updatedName;
                            newLine($"{updatedName} was updated!");
                        }
                        else
                        {
                            newLine("Invalid number. Please select a valid position.");
                        }
                        break;
                    case "drop":
                        sameLine("Number: ");
                        if (int.TryParse(Console.ReadLine(), out position) && position >= 0 && position < items.Count)
                        {
                            string droppedItem = items[position];                            
                            items.Remove(droppedItem);
                            newLine($"Dropped item: {droppedItem}");
                        }
                        else
                        {
                            newLine("Invalid, must provide a valid position");
                        }

                            break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }
            }
            static void newLine(string msg) { Console.WriteLine(msg); }
            static void sameLine(string msg) { Console.Write(msg); }
        }
    }
}
