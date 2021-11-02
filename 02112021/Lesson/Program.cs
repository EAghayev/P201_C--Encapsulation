using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Price = 40;
            product.Price  = -10;
           
            Console.WriteLine(product.Price);

            product.Price = -10;
            Console.WriteLine(product.Price);
            var discountedPrice = product.DiscountedPrice;


            double price;
            string priceStr;
            do
            {
                Console.WriteLine("Mehsulun qiymetini daxil edin:");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr,out price));

            product.Price = price;
            product.Discount = 10;
            
            product.Name = "Apple";
            product.Name = "   ";
            Console.WriteLine(product.GetInfo());

            Human user = new Human
            {
                Surname = "Abbasov",
                Name = "Hikmet"
            };


            Student student = new Student();

            Console.WriteLine(student);

        }
    }
}
