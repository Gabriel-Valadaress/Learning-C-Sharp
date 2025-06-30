namespace SecondProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type an integer number: ");
            int number = int.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(number);
            double squared = Math.Pow(number, 2);
            double cubed = Math.Pow(number, 3);

            Console.WriteLine($"\nThe square root of {number} is {squareRoot:F2}\n\nThe result of {number} squared is {squared:F2}\n\nThe result of {number} cubed is {cubed:F2}");
        }
    }
}
