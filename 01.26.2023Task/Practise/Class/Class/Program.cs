using System;

namespace Class
{
    class Product
    {
       public string Name;
       public double Price;
       public string Brand;
       public int Count;

        public string GetInfo()
        {
            string info=$"Brand:{Brand} - Name: {Name} - Price:{Price} - Count: {Count}";
            return info ;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student()
            {
                Fullname = "Faiq Ismayilov",
                GroupNo = "P231",
                Point = 67.5
            };
            Student std2 = new Student()
            {
                Fullname = "Kamran Aliyev",
                GroupNo = "P231",
                Point = 70
            };
            Student std3 = new Student()
            {
                Fullname = "Ferid Bagirov",
                GroupNo = "P231",
                Point = 80.7
            };
            Student std4 = new Student()
            {
                Fullname = "Aytac Eliyev",
                GroupNo = "P231",
                Point = 45.2
            };

            Console.WriteLine(std3.IsGraduate());
            Console.WriteLine(std2.GetInfo());

        }
    }
}
