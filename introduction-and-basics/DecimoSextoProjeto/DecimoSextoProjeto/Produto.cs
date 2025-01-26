using System;

namespace DecimoQuintoProjeto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"Nome do produto: {Nome}\n" +
                $"Preço do produto: {Preco}\n" +
                $"Quantidade do produto: {Quantidade}\n" +
                $"Valor total do produto em estoque: " + ValorTotalEmEstoque();
        }


    }
}
