using Microsoft.VisualBasic;

namespace ch06HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Print(string msg, string endLine = "\n")
            {
                Console.Write(msg + endLine);
            }
            static string GetString(string prompt)
            {
                Print(prompt, "");
                return Console.ReadLine();
            }
            static int GetInt(string prompt, int min, int max)
            {
                bool success = false;
                int nbr = 0;
                while (!success)
                {
                    Print(prompt, "");
                    nbr = Int32.Parse(Console.ReadLine());
                    if (nbr < min || nbr > max)
                    {
                        Print("Error: out of range. Try again.");
                    }
                    else
                    {
                        success = true;
                    }
                }
                return nbr;
            }
            static string GetString2(string prompt, string str1, string str2)
            {
                string retStr = "";
                bool success = false;
                while (!success)
                {
                    retStr = GetString(prompt);
                    if (retStr.ToLower() == str1 || retStr.ToLower() == str2)
                    {
                        success = true;
                    }
                    else
                    {
                        Print("Error: Entry must be either '" + str1 + "' or '" + str2 + "'. Try again.");
                    }
                }

                return retStr;

            }
            static void Random()
            {

                (int)(Math.Random() * 6) + 1;
            }
            {
                Print("Dice roller");
                string choice = "y";
                while (choice == "y")
                {
                    choice = GetString2("roll the dice? (y/n): ", "y", "n");
                    Random rand = new Random();
                    int d1 = rand.Next   
                    int d2 = rand.Next();    
                    int dieRoll = rand.Next(1, 7);
                    Print("die 1:  " + d1);
                    Print("die 2:  " + d2);
                    

                }    


                Print("Roll the dice");




                Print("Adios guapos");
            }
        }
    }
}
