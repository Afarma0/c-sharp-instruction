using System.Collections.Specialized;
using ConsoleLibrary;

namespace Chap17ProductManager
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {           
            MyConsole.PrintLine("Welcome to the product manager!\n");

            //program which provides CRUD feature for products
            //Products will be stored in a text file name products.txt

            //load products from file
            products = ProductDB.GetProducts();
            //while command != 0
            //prompt command
            //perform action: list or add product(s)

            int command = 9;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 0:
                        break;
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }

            MyConsole.PrintLine("Bye");
        }

        private static void DelProduct()
        {

        }
        private static void DeleteProducts()
        {
            MyConsole.PrintLine("\n Delete Product: ");
            MyConsole.PrintLine("===========================");

            // List products to allow user to choose one to delete
            ListProducts();

            // Ask the user for the product code to delete
            string codeToDelete = MyConsole.PromptString("Enter the product code to delete: ");

            // Attempt to delete the product using ProductDB
            ProductDB.DeleteProductByCode(products, codeToDelete);

            MyConsole.PrintLine("Product deleted successfully.");
        }

        private static void DeleteProduct()
        {
            MyConsole.PrintLine("\nDelete Product!");
            string code = MyConsole.PromptString("Product Code: ");
            for (int i = 0; i <= products.Count; i++)
            {
                Product p = products[i];
                if (p.Code != code)
                {
                    MyConsole.PrintLine("Error, entry no longer exists.");
                }
                else
                {
                    products.Remove(p);
                    MyConsole.PrintLine("Product deleted.");
                }
            }
            ProductDB.SaveProducts(products);


        }

        private static void AddProduct()
        {
            MyConsole.PrintLine("\n Add Products: ");
            MyConsole.PrintLine("===========================");
            string code = MyConsole.PromptString("Code: ");
            string desc = MyConsole.PromptString("Description: ");
            decimal price = MyConsole.PromptDecimal("Price: ");
            Product p = new Product(code, desc, price);
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintLine("Product added.");
        }

        private static void ListProducts()
        {
            MyConsole.PrintLine("\n List Products: ");
            MyConsole.PrintLine("===========================");
            //check to see if list is not empty
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.ToString()); 
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU:");
            MyConsole.PrintLine("1) List Products");
            MyConsole.PrintLine("2) Add Product");
            MyConsole.PrintLine("0) Exit");
            MyConsole.PrintLine("3) Delete");
        }
        public class Product
        {
            public string Code { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }

            public Product(string code, string description, decimal price)
            {
                this.Description = description;
                this.Code = code;
                this.Price = price;
            }
            public override string ToString()
            {
                return $"Product: ({Code}) - {Description} @ {Price:c}";
            }
        }
    }
    internal class ProductDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Products.txt";
        private const string Sep = "|";

        public static void SaveProducts(List<Product> products)
        {
            using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            //using eliminates the need in C#  for writer.clsoe()
            foreach (Product product in products)
            {
                writer.Write(product.Code + Sep);
                writer.Write(product.Description + Sep);
                writer.Write(product.Price);


            }

        }
        public static List<Product> GetProducts()
        {
            using StreamReader reader = new StreamReader(new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Product> products = new List<Product>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine();
                string[] columns = row.Split(Sep);

                if (columns.Length == 3)
                {
                    string code = columns[0];
                    string description = columns[1];
                    decimal price = Decimal.Parse(columns[2]);
                    Product p = new Product(code, description, price);
                    products.Add(p);
                }
            }
            return products;
        }


        public static void DeleteProductByCode(List<Product> products, string codeToDelete)
        {
            // Find the product in the list
            Product productToDelete = products.FirstOrDefault(p => p.Code == codeToDelete);

            if (productToDelete != null)
            {
                // Remove the product
                products.Remove(productToDelete);
                SaveProducts(products); // Update the file with the new list
            }
        }
    }
}
