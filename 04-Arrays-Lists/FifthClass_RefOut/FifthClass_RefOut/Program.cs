namespace FifthClass_RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 10;
            Console.WriteLine(n1);
            Calculator.Double(ref n1);
            Console.WriteLine(n1);
            double result;
            Calculator.Triple(n1, out result);
            Console.WriteLine(n1);
            Console.WriteLine(result);
        }
    }
}
