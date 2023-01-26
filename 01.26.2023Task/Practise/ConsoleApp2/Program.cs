using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Asus", 4000);
            product.DiscountPercent = 30;

            Product[] products = new Product[2];
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Mehsul adi:");
                string name=Console.ReadLine();
                double price;
                do
                {
                    Console.WriteLine("Qiymeti:");
                    string priceStr = Console.ReadLine();
                    price = Convert.ToDouble(priceStr);
                } while (price<0);
                Console.WriteLine("Endirim faizi:");
                string discount1=Console.ReadLine();
                double discount = Convert.ToDouble(discount1);

                Product pr = new Product(name, price, discount);

                products[i] = pr;
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }


        }
    }
}
