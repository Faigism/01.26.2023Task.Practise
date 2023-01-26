using System;

namespace _01._26._2023Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] note1 = new Notebook[3];
            for (int i = 0; i < note1.Length; i++)
            {
                Console.WriteLine("Mehsulun brendini daxil edin:");
                string brand=Console.ReadLine();
                Console.WriteLine("Mehsulun modelini daxil edin:");
                string model=Console.ReadLine();
                double price;
                do
                {
                    Console.WriteLine("Mehsulun qiymetini daxil edin:");
                    string price1 = Console.ReadLine();
                    price = Convert.ToDouble(price1);
                } while (price<=0);
                
                Notebook note2 = new Notebook(brand, model, price);
                note1[i]= note2;
            }
            foreach (var item in note1)
            {
                Console.WriteLine(item.ShowInfo());
            }
            double sum = 0;
            for (int i = 0; i < note1.Length; i++)
            {
                sum += note1[i].Price;
            }
            Console.WriteLine($"Qiymetlerin ortalamasi: "+sum/note1.Length);
        }
    }
}
