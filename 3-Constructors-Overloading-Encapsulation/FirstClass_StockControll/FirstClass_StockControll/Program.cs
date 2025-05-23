namespace FirstClass_StockControll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entry the information of the product: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            /*
            Console.Write("Quantity in the stock: ");
            int quantity = int.Parse(Console.ReadLine());
            */

            Product product = new Product(name, price);

            Console.WriteLine(product);

            Console.Write($"How many units of {product.Name} do you want to add in stock? ");
            product.AddQuantity(int.Parse(Console.ReadLine()));
            Console.WriteLine(product);

            Console.Write($"How many units of {product.Name} do you want to remove from stock? ");
            product.RemoveQuantity(int.Parse(Console.ReadLine()));
            Console.WriteLine(product);
        }
    }
}
