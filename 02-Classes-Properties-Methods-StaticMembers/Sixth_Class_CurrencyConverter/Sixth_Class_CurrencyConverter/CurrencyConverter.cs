using System;

namespace Sixth_Class_CurrencyConverter
{
    class CurrencyConverter
    {
        public static double Convert(double exchangeRate, double baseCurrency)
        {
            return baseCurrency / exchangeRate;
        }
    }
}
