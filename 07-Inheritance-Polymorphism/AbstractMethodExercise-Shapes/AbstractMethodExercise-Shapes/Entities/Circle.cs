using System;
using AbstractMethodExercise_Shapes.Entities.Enums;

namespace AbstractMethodExercise_Shapes.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle (double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override string ToString()
        {
            return "Shape: Circle, " + base.ToString();
        }
    }
}
