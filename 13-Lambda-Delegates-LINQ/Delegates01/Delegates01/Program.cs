using Delegates01.Services;

namespace Delegates01
{
    public class Program
    {
        delegate void BynaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 15;

            BynaryNumericOperation op = CalculationService.ShowSum;

            op(a, b);

            Console.WriteLine("------------------");

            op += CalculationService.ShowMax;

            op(a, b);
        }
    }
}
