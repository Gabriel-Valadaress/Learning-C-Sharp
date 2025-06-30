using System;
using AbstractMethodExercise_Shapes.Entities.Enums;

namespace AbstractMethodExercise_Shapes.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return "Shape: Rectangle, " + base.ToString();
        }
    }
}
