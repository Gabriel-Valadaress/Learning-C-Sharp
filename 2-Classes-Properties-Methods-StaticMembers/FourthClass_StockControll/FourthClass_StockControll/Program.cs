namespace FourthClass_StockControll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entry the information of the product: ");
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity in the stock: ");
            product.Quantity = int.Parse(Console.ReadLine());
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
