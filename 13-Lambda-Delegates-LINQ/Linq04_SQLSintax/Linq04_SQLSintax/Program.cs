using Linq04_SQLSintax.Entities;

namespace Linq04_SQLSintax
{
    public class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category category1 = new Category(1, "Tools", 2);
            Category category2 = new Category(2, "Computers", 1);
            Category category3 = new Category(3, "Electronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer X", 1100, category2),
                new Product(2, "Hammer", 25.99, category1),
                new Product(3, "Smartphone", 799.99, category3),
                new Product(4, "Screwdriver Set", 35.50, category1),
                new Product(5, "Monitor", 249.99, category2),
                new Product(6, "Headphones", 99.99, category3),
                new Product(7, "Keyboard", 59.99, category2),
                new Product(8, "Power Drill", 89.99, category1),
                new Product(9, "Mouse", 24.99, category2),
                new Product(10, "TV", 699.99, category3),
                new Product(11, "Laptop", 1299.99, category2),
                new Product(12, "Wireless Earbuds", 149.99, category3)
            };

            var result1 = from p in products
                          where p.Category.Tier == 1 && p.Price < 900
                          select p;
            Print("TIER 1 AND PRICE < 900:", result1);

            var result2 = from p in products
                          where p.Category.Name == "Tools"
                          select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", result2);

            var result3 = from p in products
                          where p.Name.StartsWith('C')
                          select new
                          {
                              p.Name,
                              p.Price,
                              CategoryName = p.Category.Name
                          };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", result3);

            var result4 = (from p in products select p).Skip(2).Take(4).OrderBy(p => p.Name);
            Print("SKIP 2 TAKE 4 AND ORDER BY NAME", result4);
        }
    }
}