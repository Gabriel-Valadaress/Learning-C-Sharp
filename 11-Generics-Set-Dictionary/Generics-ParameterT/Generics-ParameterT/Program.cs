using Generics_ParameterT.Services;

namespace Generics_ParameterT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printServiceInt = new PrintService<int>();
            PrintService<string> printServiceString = new PrintService<string>();

            Console.Write("How many integers do you want to print? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Integer #{i+1}: ");
                printServiceInt.AddValue(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Integers:");
            Console.WriteLine("Fist: " + printServiceInt.First());
            printServiceInt.Print();

            Console.WriteLine();

            Console.Write("How many strings do you want to print? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"String #{i + 1}: ");
                printServiceString.AddValue(Console.ReadLine());
            }

            Console.WriteLine("Strings:");
            Console.WriteLine("Fist: " + printServiceString.First());
            printServiceString.Print();
        }
    }
}
