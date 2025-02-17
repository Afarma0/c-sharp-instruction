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
    }
}
