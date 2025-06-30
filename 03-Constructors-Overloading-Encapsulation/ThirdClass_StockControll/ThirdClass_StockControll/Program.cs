namespace ThirdClass_StockControll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product;

            //Register
            Console.Write("Type the product code: ");
            int code = int.Parse(Console.ReadLine());
            Console.Write("Type the product name: ");
            string name = Console.ReadLine();
            Console.Write("Type the product price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write($"Do you want to add any {name} in stock? (y/n) ");
            char response = char.Parse(Console.ReadLine());

            if (response == 'y' || response == 'Y')
            {
                Console.Write($"Type how many {name} do you want to add in stock: ");
                long initialQuantity = long.Parse(Console.ReadLine());
                product = new Product(code, name, price, initialQuantity);
            }
            else
            {
                product = new Product(code, name, price);
            }

            Console.WriteLine(product);

            //Add
            Console.Write($"Type how many of {product.ProductName} you want to add in stock: ");
            long quantity = long.Parse(Console.ReadLine());
            product.AddProductInStock(quantity);

            Console.WriteLine(product);

            //Remove
            Console.Write($"Type how many of {product.ProductName} you want to remove from stock: ");
            quantity = long.Parse(Console.ReadLine());
            product.RemoveProductInStock(quantity);

            Console.WriteLine(product);

            //Rename
            Console.Write($"Type the new name of {product.ProductName}: ");
            name = Console.ReadLine();
            product.ChangeProductName(name);

            Console.WriteLine(product);

            //Ajust Price
            Console.Write($"Type the new price of {product.ProductName}: ");
            price = double.Parse(Console.ReadLine());
            product.ChangeProductPrice(price);

            Console.WriteLine(product);
        }
    }
}
