namespace DecimoTerceiroEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadosPessoas primeiraPessoa, segundaPessoa;
            primeiraPessoa = new DadosPessoas();
            segundaPessoa = new DadosPessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.Nome}");
            }
            else if (segundaPessoa.Idade == primeiraPessoa.Idade)
            {
                Console.WriteLine($"{primeiraPessoa.Nome} e {segundaPessoa.Nome} possuem a mesma idade!");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segundaPessoa.Nome}");
            }




        }
    }
}
