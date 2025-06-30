namespace SecondClass_ObjectArray

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many product do you want to register? ");
            int quantity = int.Parse(Console.ReadLine());
            string message = "";
            double avg = 0;

            Product[] productArr = new Product[quantity];

            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Type the name of the product: ");
                string name = Console.ReadLine();
                Console.Write($"Type the price of the {name}: ");
                double price = double.Parse(Console.ReadLine());
                productArr[i] = new Product { Name = name, Price = price };
                message += ($"\nProduct Name: {productArr[i].Name}\nProduct Price: $ {productArr[i].Price:F2}\n");
                avg += productArr[i].Price;
            }
            Console.WriteLine(message);
            avg = avg / productArr.Length;
            Console.WriteLine($"A média dos preços é: $ {avg:F2}");
        }
    }
}
