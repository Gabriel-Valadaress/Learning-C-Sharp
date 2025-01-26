namespace DecimoSegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double aX = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());
            double pX = (aX + bX + cX) / 2;
            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double aY = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());
            double pY = (aY + bY + cY) / 2;
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));
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
