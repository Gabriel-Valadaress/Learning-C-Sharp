using ExtendingDateTime.Extensions;

namespace ExtendingDateTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 6, 30, 10, 40, 30);

            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
