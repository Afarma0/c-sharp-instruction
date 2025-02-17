using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleLibrary;

namespace Chap17ProductManager
{
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

