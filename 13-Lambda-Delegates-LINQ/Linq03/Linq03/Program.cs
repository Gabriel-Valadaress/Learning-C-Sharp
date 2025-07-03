using Linq03.Entities;

namespace Linq03
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
                new Product(8, "Power Drill", 81.99, category1),
                new Product(9, "Mouse", 24.99, category2),
                new Product(10, "TV", 699.99, category3),
                new Product(11, "Laptop", 1299.99, category2),
                new Product(12, "Wireless Earbuds", 149.99, category3)
            };

            var result1 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + result1);

            var result2 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum Prices of tier 1 products: " + result2);

            var result3 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average Prices of category 1 products: " + result3);
            
            var result4 = products.Where(p => p.Category.Id == 4).Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine("Average Prices of category 4 products: " + result4);

            var result5 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + result5);

            var result6 = products.GroupBy(p => p.Category);
            foreach( IGrouping<Category, Product> group in result6)
            {
                Console.WriteLine("Category: " + group.Key.Name);
                foreach( Product product in group)
                {
                    Console.WriteLine(product);
                }   
            }
        }
    }
}