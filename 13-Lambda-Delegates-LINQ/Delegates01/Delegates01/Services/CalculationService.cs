namespace Delegates01.Services
{
    public static class CalculationService
    {
        public static void ShowSum(double n1, double n2)
        {
            Console.WriteLine("Sum: " + (n1 + n2));
        }

        public static void ShowMax(double n1, double n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("Max: " + n1);
            }
            else
            {
                Console.WriteLine("Max: " + n2);
            }
        }
    }
}
