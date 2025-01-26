namespace VigesimoPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.valorASerPago(dolar, cotacao));
        }
    }
}
