using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Product
    {
        public string Name;
        public double Price;
        public ushort Count;

        public Product(string name, double price, ushort count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public double GetPrice()
        {
            return Price * Count;
        }
    }
}
