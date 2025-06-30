using System;

namespace SecondClass_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2025, 5, 7);
            Console.WriteLine($"Date: {date}");

            date = date.AddSeconds(10);
            Console.WriteLine($"Date + 10s: {date}");

            date = date.AddMinutes(10);
            Console.WriteLine($"Date + 10min: {date}");

            date = date.AddHours(10);
            Console.WriteLine($"Date + 10h: {date}");

            date = date.AddDays(10);
            Console.WriteLine($"Date + 10d: {date}");

            date = date.AddMonths(10);
            Console.WriteLine($"Date + 10mth: {date}");

            date = date.AddYears(10);
            Console.WriteLine($"Date + 10y: {date}");
        }
    }
}
