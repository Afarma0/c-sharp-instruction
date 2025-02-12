namespace Ch06Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Chapter 6: ");
            //get infor for movie (title, year, rating, director)
            string choice = "y";
            while (choice == "y")
            {
                string title = GetString("enter movie title: ");
                int year = GetInt("Enter release year: ", 1900, 2050);
                string rating = GetString("Enter rating: ");
                string director = GetString("Enter director: ");


                //validate y or n
                choice = GetString("Continue? (y/n): ", "y", "n");
            }

            Print("Hello, World!");
        }
        static int GetInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }
        static int GetInt(string prompt, int min, int max){
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

        static string GetString(string prompt, string str1, string str2) 
        {
            string retStr = "";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr.ToLower() == str1 || retStr.ToLower() == str2){
                    success = true;
                }
                else
                {
                    Print("Error: Entry must be either '" + str1 + "' or '" + str2 + "'. Try again.");
                }
            }

            return retStr;
        
        }

        //Get string method: accpets a prompt: string & returns a string from the console
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();           
        }
        //method accepts one input variable, returns void (no return value)
        static void Print(string msg, string endLine="\n"){
            Console.Write(msg + endLine); }
    }
}
