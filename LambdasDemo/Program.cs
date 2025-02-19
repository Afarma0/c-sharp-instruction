using ConsoleLibrary;

namespace LambdasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the lambdas demo!");



            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            

            for (int i=0; i < numbers.Count; i++) {
                MyConsole.Print($"{i}");
                List<int> squaredNums1 = new() { (int)numbers[i * i] };
                List<int> divThree1 = new() { (int)numbers[i % 3] };
                            if (numbers[i % 3] == 0);
                MyConsole.PrintLine($"squaredNums1 list: {squaredNums1}");
                MyConsole.PrintLine($"divthree1 list: {divThree1}");
            }
            //for (int i = 0; i < numbers.Count; i++)
            //    List<int> squaredNums1 = new() { (int)numbers[i * i] };
            //create a new list called squaredNums1
            //store the squared versions of all numbers


            //create a new list called divThree1
            //store the nums from numbers that are evenly divisible by three


        }
    }
}
