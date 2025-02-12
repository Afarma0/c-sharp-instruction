using System.Diagnostics.CodeAnalysis;

namespace ch08Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ch8 arrays!");

            //p. 231
            //array of strings - names
            string[] names = new string[9];
            names[0] = "Jim";
            names[1] = "Andy";
            names[2] = "nick";
            names[3] = "Christian";
            names[4] = "Adrian";
            names[5] = "Andy";
            names[6] = "nick";
            names[7] = "Christian";
            names[8] = "Adrian";

            Console.WriteLine("names = " + names);
            Console.WriteLine("position 0" +names[0]);

            for (int i = 0; i < names.Length; i++)
            {
                Print("i: " + i + ", name: "+ names[i]);    
            }

            //names[9] = "new person"; --DOES NOT WORK
            //no adding to the array

            decimal[] prices = { 1.99m, 2.25m, 4.5m };
            for (int i = 0; i < prices.Length; i++) 
            { Print("i: " + i + ", price: " + prices[i]); }

            var grades = new[] { 95.0, 89.0, 91.0, 98.0 };
            double sum = 0;
            for (int i = 0; i < grades.Length; i++) { 
            sum += grades[i];  
            }
            Print("sum: " + sum);
            Print("avg: " + sum / grades.Length);
            //var stuff = new[] { "A", 5, 7.7};
            //arrays must be all of the same type

            string fullName = "Bob Nesta Marley";
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.Write(fullName[i] + " ");
            }
            Console.WriteLine();

            //for each loop
                //no access to incrementer
                    //e.g. loop through names and print on one line
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();


            //p239
            // 3 X 4 grid
            // 1  2  3  4
            // 5  6  7  8
            // 9 10 11 12

            int[,] grid = new int[3, 4];
            grid[0,0] = 1;
            grid[0,1] = 2;
            grid[0,2] = 3;
            grid[0,3] = 4;
            grid[1,0] = 5;
            grid[1,1] = 6;
            grid[1,2] = 7;
            grid[1,3] = 8;
            grid[2,0] = 9;
            grid[2,1] = 10;
            grid[2,2] = 11;
            grid[2,3] = 12;

            //print grid
            //i loop rows
            string gridString = "";
            for (int i = 0; i < grid.GetLength(0);i++)
            {
                //j loop - columns
                for (int j = 0; j < grid.GetLength(1);j++)
                {
                    gridString += grid[i, j] + "\t";
                }
                gridString += "\n";
            }
            Print(gridString);

            //array class
            Array.Sort(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }













            Print("bye");
        }
        
        
        private static void Print(string prompt) {
            Console.WriteLine(prompt);
}

    }
}
