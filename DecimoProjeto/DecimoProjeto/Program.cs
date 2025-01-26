using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numeroInteiro = int.Parse(Console.ReadLine());

            while (numeroInteiro >= 0)
            {
                Console.WriteLine(Math.Sqrt(numeroInteiro));
                Console.WriteLine("Digite outro número inteiro:");
                numeroInteiro = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número Negativo!");
        }
    }
}