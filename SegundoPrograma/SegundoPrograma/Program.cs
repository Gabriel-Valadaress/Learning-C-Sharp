using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 255;
            int n2 = n1 * 2;
            long n3 = n2 * 2;
            float n4 = 4.5f;
            double n5 = 4.5;
            string nome = "Gabriel";
            int minimo = int.MinValue;
            int maximo = int.MaxValue;
            long maximoLong = long.MaxValue;

           
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(nome);
            Console.WriteLine(minimo);
            Console.WriteLine(maximo);
            Console.WriteLine(maximoLong);
        }
    }
}