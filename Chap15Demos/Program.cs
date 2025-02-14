using ConsoleLibrary;

namespace Chap15Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Summarizable> summarizables = new List<Summarizable>();    
            //create products
            Product p1 = new Product("c#", "Murach csharpie", 53.99m);
            Product p2 = new Product("mysql", "Murach sql", 44.99m);
            Product p3 = new Product("andr", "Murach andr", 63.99m);

            summarizables.Add(p1);
            summarizables.Add(p2);
            summarizables.Add(p3);
            //create cust
            Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
            Customer c2 = new Customer("Celina", "Saksith", "CS0020");
            summarizables.Add(c1);
            summarizables.Add(c2);



            //print summary
            //^^we need a GetSummaryDetails() method on the classes 
            //added to interface
            MyConsole.PrintLine("Summary: ");
            foreach (var item in summarizables)
            {
                MyConsole.PrintLine($"{item.GetSummaryDetails()}");
            }
            
            //sort list of products
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            MyConsole.PrintLine("=== All Products ===");
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.GetSummaryDetails());
            }
            //sort
            products.Sort();
            MyConsole.PrintLine("=== Sorted Products ===");
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.GetSummaryDetails());
            }




            MyConsole.PrintLine("bye");

        }        
    }
}
