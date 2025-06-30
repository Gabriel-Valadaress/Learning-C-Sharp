using ComparingCollections.Entities;

namespace ComparingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<IncorrectProduct> set1 = new HashSet<IncorrectProduct>();

            set1.Add(new IncorrectProduct("TV", 409.99));
            set1.Add(new IncorrectProduct("Stove", 219.19));

            IncorrectProduct stove1 = new IncorrectProduct("Stove", 219.19);

            Console.WriteLine("set contains stove? " + set1.Contains(stove1));

            Console.WriteLine("------------------");

            HashSet<Product> set2 = new HashSet<Product>();

            set2.Add(new Product("TV", 409.99));
            set2.Add(new Product("Stove", 219.19));

            Product stove2 = new Product("Stove", 219.19);

            Console.WriteLine("set contains stove? " + set2.Contains(stove2));
        }
    }
}
