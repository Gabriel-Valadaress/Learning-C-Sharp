using StringExtension.Extensions;

namespace StringExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
           string helloWorld = "Hello, World!";

            Console.WriteLine(helloWorld.Cut(5));
        }
    }
}
