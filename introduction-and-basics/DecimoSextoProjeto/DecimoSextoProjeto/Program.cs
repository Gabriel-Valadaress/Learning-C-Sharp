namespace DecimoQuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto caixas = new Produto();

            Console.Write("Digite o nome do produto para cadastro no estoque: ");
            caixas.Nome = Console.ReadLine();
            Console.Write("Digite o preço unitário do produto: ");
            caixas.Preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto no estoque: ");
            caixas.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(caixas);

            Console.Write($"Quantos(as) {caixas.Nome} você deseja adicionar no estoque? ");
            caixas.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine(caixas);

            Console.Write($"Quantos(as) {caixas.Nome} você deseja remover no estoque? ");
            caixas.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine(caixas);
        }
    }
}
