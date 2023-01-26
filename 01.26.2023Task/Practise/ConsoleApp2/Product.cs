using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Product
    {
        public Product(string name,double price,double discountpercent=0)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name;
        public double Price;
        public double DiscountPercent;
    }
}
