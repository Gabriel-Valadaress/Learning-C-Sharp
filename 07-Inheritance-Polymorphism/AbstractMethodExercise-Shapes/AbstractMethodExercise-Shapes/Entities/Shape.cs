using System;
using AbstractMethodExercise_Shapes.Entities.Enums;

namespace AbstractMethodExercise_Shapes.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape (Color color)
        {
            Color = color;
        }

        public abstract double Area();

        public override string ToString()
        {
            return $"Color: {Color}, Area: {Area():F2}";
        }
    }
}
