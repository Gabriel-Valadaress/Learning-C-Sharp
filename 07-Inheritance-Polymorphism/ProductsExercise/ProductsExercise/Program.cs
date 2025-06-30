using ProductsExercise.Entities;

namespace ProductsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProduct = int.Parse(Console.ReadLine());

            for (int i = 1; i <=numberOfProduct; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char procedence = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product;

                if (procedence == 'u')
                {
                    Console.Write("Manufacture date (YYYY-MM-DD): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    product = new UsedProduct(name, price, manufactureDate);
                    products.Add(product);
                }

                if (procedence == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    product = new ImportedProduct(name, price, customFee);
                    products.Add(product);
                }

                if (procedence == 'c')
                {
                    product = new Product(name, price);
                    products.Add(product);
                }
            }

            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
