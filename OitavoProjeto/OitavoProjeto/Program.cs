using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string par;

            if (a % 2 == 0)
            {
                par = "par";
            }
            else
            {
                par = "impar";
            }

            if (a < 10)
            {
                Console.WriteLine($"Menor que 10 e {par}");
            }
            else if (a == 10)
            {
                Console.WriteLine($"Igual a 10 e {par}");
            }
            else
            {
                Console.WriteLine($"Maior que 10 e {par}");
            }


        }
    }
}