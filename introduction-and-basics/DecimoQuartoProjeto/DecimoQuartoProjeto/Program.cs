﻿namespace DecimoQuartoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            double areaX = x.Area();

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Áreas iguais!");
            }
        }
    }
}
