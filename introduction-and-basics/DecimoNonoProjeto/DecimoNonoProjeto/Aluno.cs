using System;

namespace DecimoNonoProjeto
{
    internal class Aluno
    {
        public string Nome;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;

        public double NotaFinal()
        {
            return (PrimeiraNota + SegundaNota + TerceiraNota);
        }

        public double FaltaParaPassar()
        {
            return 60 - NotaFinal();
        }
    }
}
