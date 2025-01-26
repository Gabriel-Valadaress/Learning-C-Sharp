namespace VigesimoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Valor de PI: " + Calculadora.Pi);
        }
    }
}
