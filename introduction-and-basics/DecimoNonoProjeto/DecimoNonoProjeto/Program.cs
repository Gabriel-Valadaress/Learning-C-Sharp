namespace DecimoNonoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine());
            aluno.SegundaNota = double.Parse(Console.ReadLine());
            aluno.TerceiraNota = double.Parse(Console.ReadLine());

            if (aluno.NotaFinal() >= 60)
            {
                Console.WriteLine($"Nota final = {aluno.NotaFinal():F2}\n" +
                    $"Aprovado");
            }
            else
            {
                Console.WriteLine($"Nota final = {aluno.NotaFinal():F2}\n" +
                    $"Reprovado\n" +
                    $"Faltaram {aluno.FaltaParaPassar():F2} pontos");
            }
        }
    }
}
