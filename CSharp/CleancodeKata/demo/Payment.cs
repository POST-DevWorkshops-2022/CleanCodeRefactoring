using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CSharpCore
{
    public class Payment
    {
        public Payment(double price, bool made)
        {
            this.price = price;
            this.made = made;
        }

        public double price { get; set; }
        public bool made { get; set; }
    }
}
