﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap17ProductManager
{
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
        public override string ToString() {
            return $"Product: ({Code}) - {Description} @ {Price:c}";
        }
    }
}

