﻿


namespace FourthClass_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2, 3, 4, 5);
            int s2 = Calculator.Sum(1, 2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
