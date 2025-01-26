namespace DecimoTerceiroEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionarios primeiroFuncionario, segundoFuncionario;
            primeiroFuncionario = new Funcionarios();
            segundoFuncionario = new Funcionarios();

            double salarioMedio = 0.00;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine());

            salarioMedio = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {salarioMedio}");
        }
    }
}
