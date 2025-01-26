namespace DecimoPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números deseja somar? ");
            int QuantidadeN = int.Parse(Console.ReadLine());
            int Soma = 0;

            for (int i = 0; i < QuantidadeN; i++)
            {
                int j = i + 1;
                Console.Write("Valor #" + j + ": ");
                int NumeroParaSomar = int.Parse(Console.ReadLine());
                Soma += NumeroParaSomar;
            }
            Console.WriteLine("Soma = " + Soma);
        }
    }
}
