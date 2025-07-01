using Delegates04.Entities;

namespace Delegates04
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

            List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
