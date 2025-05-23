using System;

namespace FirstClass_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            Console.WriteLine($"Blank date: {date1}");

            DateTime date2 = DateTime.Now;
            Console.WriteLine($"Current date: {date2}");          
            Console.WriteLine($"Ticks - How date is storage: {date1.Ticks}\nTicks - How date is storage: {date2.Ticks}");

            DateTime date3 = DateTime.UtcNow;
            Console.WriteLine($"Current UTC date: {date3}");

            string stringDate = "2025-05-07 15:41:27";
            DateTime date4 = DateTime.Parse(stringDate);
            Console.WriteLine($"Date from string: {date4}");
            Console.WriteLine($"Year: {date4.Year}\nMonth: {date4.Month}\nDay: {date4.Day}\nHours: {date4.Hour}\nMinutes: {date4.Minute}\nSeconds: {date4.Second}\nDay of week: {date4.DayOfWeek}\nDay of year: {date4.DayOfYear}");

            DateTime finish = DateTime.Now;
            Console.WriteLine($"Current date: {finish}");
            Console.WriteLine($"Execution time: {(finish - date2).TotalSeconds} seconds or {(finish - date2).TotalMilliseconds} miliseconds");
        }
    }
}
