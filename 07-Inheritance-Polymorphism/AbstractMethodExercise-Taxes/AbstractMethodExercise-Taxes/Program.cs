using AbstractMethodExercise_Taxes.Entities;

namespace AbstractMethodExercise_Taxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>();

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (response == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    Entity entity = new Company(name, income, employeesNumber);
                    entities.Add(entity);
                }
                else if (response == 'i')
                {
                    Console.Write("Health expenditures: ");
                    int healthExpenses = int.Parse(Console.ReadLine());
                    Entity entity = new Individual(name, income, healthExpenses);
                    entities.Add(entity);
                }
            }

            Console.WriteLine("\nTaxes Paid:");

            double totalTaxes = 0;
            foreach(Entity entity in entities)
            {
                Console.WriteLine(entity);
                totalTaxes += entity.TaxesPaid();
            }

            Console.WriteLine("\nTotal Taxes: $ " + totalTaxes.ToString("F2"));
        }
    }
}
