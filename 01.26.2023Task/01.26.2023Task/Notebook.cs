using System;
using System.Collections.Generic;
using System.Text;

namespace _01._26._2023Task
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;

        public Notebook(string brend,string model,double price=0)
        {
            this.Brand = brend;
            this.Model = model;
            this.Price = price;
        }

        public string ShowInfo()
        {
            return $"Brendi: {Brand} - Modeli: {Model} - Qiymeti: {Price}";
        }

    }
}
