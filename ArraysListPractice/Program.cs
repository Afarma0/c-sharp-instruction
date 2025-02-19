using ConsoleLibrary;

namespace ArraysListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            MyConsole.PrintLine(numbers.ToString());

            List<string> names = new List<string>();

            names.Add("a");
            names.Add("b");
            names.Add("c");  
            names.Add("d");
            names.Add("e");
            names.Add("f");
            names.Add("g");
            names.Add("h");
            names.Add("i");
            names.Add("j");

            List<int> doublenumbers = new List<int>();

            foreach (var number in numbers)
            {
                doublenumbers.Add(number * 2);
            }

        }
    }
}
