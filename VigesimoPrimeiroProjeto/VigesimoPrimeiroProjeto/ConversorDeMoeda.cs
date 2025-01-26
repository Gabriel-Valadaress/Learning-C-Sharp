using System;

namespace VigesimoPrimeiroProjeto
{
    internal class ConversorDeMoeda
    {
        public static double valorASerPago(double dolar, double cotacao)
        {
            return dolar * cotacao * 1.06;
        }
    }
}
