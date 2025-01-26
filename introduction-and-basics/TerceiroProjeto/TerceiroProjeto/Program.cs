using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 4.75968;
            string nome = "Gabriel";
            Console.WriteLine(numero.ToString("F2"));
            Console.WriteLine(numero.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1:F2} de dinheiro no banco {2}", nome, numero, nome);
            Console.WriteLine($"{nome} tem {numero:F2} de dinheiro no banco {nome}");

        }
    }
}