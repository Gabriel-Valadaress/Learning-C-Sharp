using System;

namespace DecimoSetimoProjeto
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"Area = {Area():F2}\n" +
                $"Perímetro = {Perimetro():F2}\n" +
                $"Diagonal = {Diagonal():F2}";
        }
    }
}
