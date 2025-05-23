namespace Sixth_Class_CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the current exchange rate for the US dollar in your base currency? ");
            double exchangeRate = double.Parse(Console.ReadLine());
            Console.Write("How much of your base currency would you like to exchange? ");
            double baseCurrency = double.Parse(Console.ReadLine());
            Console.WriteLine($"At an exchange rate of {exchangeRate:F2} per USD, {baseCurrency:F2} in your base currency will give you {CurrencyConverter.Convert(exchangeRate,baseCurrency):F2} US dollars.");
        }
    }
}
