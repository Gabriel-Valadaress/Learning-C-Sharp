using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[] vetorPalavras = Console.ReadLine().Split(' ');
            string nome = vetorPalavras[0];
            char sexo = char.Parse(vetorPalavras[1]);
            int idade = int.Parse(vetorPalavras[2]);
            double altura = double.Parse(vetorPalavras[3]);

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}