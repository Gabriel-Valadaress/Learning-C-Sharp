using Delegates03.Entities;

namespace Delegates03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Tv", 900));
            products.Add(new Product("Mouse", 50));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD case", 80.90));

            Console.WriteLine("Default");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------");

            Action<Product> action = p =>
            {
                p.Price *= 1.1;
            };

            products.ForEach(action);

            Console.WriteLine("+10%:");

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------------");

            Console.WriteLine("+10%:");

            products.ForEach(p => p.Price *= 1.1);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
