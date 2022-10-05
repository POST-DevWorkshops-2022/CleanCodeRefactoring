using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    public class Product
    {
        public Product(double price, bool inStock)
        {
            this.price = price;
            this.inStock = inStock;
        }

        public double price { get; set; }
        public bool inStock { get; set; }

       
    }
}
