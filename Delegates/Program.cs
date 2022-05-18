using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product("Milk", 2.5, 50);
            Product bread = new Product("Bread", 0.5, 70);
            Product cola = new Product("CocaCola", 1.7, 40);
            Product water = new Product("Milk", 0.3, 10);

            List<Product> products = new List<Product>(4)
            {
                milk,
                bread,
                cola,
                water
            };

            Order order = new Order(products);
        }
    }
}
