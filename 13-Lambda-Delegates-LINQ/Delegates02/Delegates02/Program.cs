using Delegates02.Entities;

namespace Delegates02
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

            products.RemoveAll(PriceGreaterOrEqual100);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        static bool PriceGreaterOrEqual100(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
