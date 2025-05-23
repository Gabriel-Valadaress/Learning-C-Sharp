using System;

namespace FirstClass_TriangleCalculator
{
    class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public double Area()
        {
            double p = (SideA + SideB + SideC) / 2.0;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

    }
}
