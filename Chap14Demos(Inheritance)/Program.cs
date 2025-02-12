using ConsoleLibrary;

namespace Chap14Demos_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int nbr1 = 11;

            Movie m1 = new Movie(1, "test", 2000, "PG", "Test");
            MyConsole.PrintLine(m1.ToString());
            Movie m2 = new Movie(1, "test2", 2000, "PG", "Test2");
            Movie m3 = new Movie(1, "test2", 2000, "PG", "Test2");
            MyConsole.PrintLine(m2.ToString());

            int nbr2 = 11;
            MyConsole.PrintLine($"nbr1==nbr2? {nbr1==nbr2}");
            MyConsole.PrintLine($"m1==m2? {m1 == m2}");
            MyConsole.PrintLine($"m3==m2? {m3 == m2}");


            Movie m4 = m3;
            MyConsole.PrintLine($"m3==m4? {m3 == m4}");

            //creat instances of product
            //Product p1 = new Product("C#", "Murach's C#", 54.99m);
            //Product p2 = new Product();
            //MyConsole.PrintLine(p1.GetDisplayText("|"));

            Book b1 = new Book("java", "Murach's Java", 49.99m, "Joel Murach");
            MyConsole.PrintLine(b1.GetDisplayText("|"));

            Software s1 = new Software("vs", "Visual Studio", 0.0m, "8.0");
            MyConsole.PrintLine(s1.GetDisplayText("|"));

            Book b2 = new Book("C#", "Murach's C#", 54.99m, "m");
            Book b3 = new Book("C#", "Murach's C#", 54.99m, "M");

            //put books and software into a list and print summary
            List<Product> pr = new List<Product>();
            pr.Add(b1);
            pr.Add(b2);
            pr.Add(b3);
            pr.Add(s1);

            MyConsole.PrintLine("-----------Products Summary----------");
            foreach (Product p in pr)
            {
                MyConsole.PrintLine(p.GetDisplayText("|"));
            }

            MyConsole.PrintLine("BYE");
        }
    }
}
