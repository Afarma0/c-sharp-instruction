namespace ch08DemoLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to collections!");


            
            Random random = new Random(); //creates new instance of random class
            int dieRoll = random.Next(1, 7);

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            
            List<string> names = new List<string>();
            names.Add("Jim");
            names.Add("Joe");

            names.Insert(1, "Test");

            foreach (string n in names)
            {
                Console.Write(n + " ");
            }
            
            Console.WriteLine();

            Console.WriteLine(names);

            Console.WriteLine("Adrian? "+ names.Contains("Adrian"));

            names.Remove("Test");
            foreach (string n in names)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //what's the index position for Joe?
            Print("Joe in position: " + names.BinarySearch("Jim"));
            Print("Joe in position: " + names.IndexOf("Jim"));


            Console.WriteLine("bye");
        }
        private static void Print(string prompt) { Console.WriteLine(prompt); }
    }
}
