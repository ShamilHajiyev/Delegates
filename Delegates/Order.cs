using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void Callback(DateTime date);

    class Order
    {
        public List<Product> Products;
        public double TotalPrice;
        public DateTime Date;

        public Order(List<Product> products)
        {
            Products = products;
            Date = DateTime.Now;
            foreach (Product product in Products)
            {
                TotalPrice += product.GetPrice();
            }
            Action<DateTime> sell = delegate (DateTime date)
            {
                double discount = 0;
                if (TotalPrice > 100 && TotalPrice < 200)
                {
                    discount = 10;
                }
                else if (TotalPrice > 200)
                {
                    discount = 20;
                }
                TotalPrice *= (1 - discount / 100);
                Console.WriteLine($"Date: {date}\nDiscount: {discount}%\nTotal: {TotalPrice} azn");
            };
            sell(Date);
        }
    }
}
