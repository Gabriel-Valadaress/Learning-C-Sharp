using System;

namespace FifthClass_RefOut
{
    class Calculator
    {
        public static void Double (ref double number)
        {
            number *= 2;
        }

        public static void Triple (double number, out double result)
        {
            result = number * 3;
        }
    }
}
