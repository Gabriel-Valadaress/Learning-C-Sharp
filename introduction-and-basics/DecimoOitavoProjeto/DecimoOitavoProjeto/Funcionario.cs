using System;

namespace DecimoOitavoProjeto
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1 + porcentagem/100);
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}, $ {SalarioLiquido():F2}";
        }
    }
}
