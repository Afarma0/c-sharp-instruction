using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15Demos
{
    internal class Product : Summarizable, IComparable<Product>
    {
        public string Code { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Product: ({Code}) ({Description}) @ {Price:c}";
            return summary; 
            
            
        }

        public int CompareTo(Product? other)
        {
            return this.Code.CompareTo(other?.Code);
            
        }
    }

}
