namespace ch0882DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sales Report Application!\n");

            decimal[,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m},
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m},
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m},
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m}
            };
            decimal sum = 0.0m;
            //1) dump data to console by region (rows), quarter (columns)
            //header (top row) happens once and only once
            newLine("Region\t Q1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                sameLine((i + 1) + "\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sameLine(sales[i, j].ToString("c") + "\t");
                }
                newLine("");
            }
            newLine("");
            newLine("Sales by region: ");
            //2) sum Sales by region (region 1, 2, 3, 4)
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                sameLine("Region "+ (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
                newLine(sum.ToString("c"));
            }
            newLine("");

            //3) sum sales by quarter (Q1, Q2, Q3, Q4)
            newLine("Sales by quarter: ");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                sameLine("Q" + (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[j, i];
                }
                newLine(sum.ToString("c"));
            }
            newLine("");

            //4) Total sales (sum of all data)
            sameLine("Total sales: ");
            sum = 0.0m;
            for (int i = 0; i < sales.GetLength(0); i++)
            {                              
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                }
                
            }
            newLine(sum.ToString("c"));
            newLine("");
            newLine("Bye!");


            
        }
        static void newLine(string msg) {  Console.WriteLine(msg); }
        static void sameLine(string msg) { Console.Write(msg); }
    }
}
