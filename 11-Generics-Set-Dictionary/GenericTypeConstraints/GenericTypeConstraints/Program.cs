using GenericTypeConstraints.Entities;
using GenericTypeConstraints.Services;
using System.Globalization;

namespace GenericTypeConstraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("How many products do you want to add in the list? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Product #{i+1} (Name,Price): ");
                string[] productVect = Console.ReadLine().Split(',');
                list.Add(new Product(productVect[0], double.Parse(productVect[1], CultureInfo.InvariantCulture)));
            }

            CalculationService calculationService = new CalculationService();

            Console.WriteLine("Max: " + calculationService.Max(list));

        }
    }
}
