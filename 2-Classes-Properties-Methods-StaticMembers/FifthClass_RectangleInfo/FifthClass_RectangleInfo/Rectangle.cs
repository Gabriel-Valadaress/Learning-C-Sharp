using System;

namespace FifthClass_RectangleInfo
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(this.Width,2) + Math.Pow(this.Height,2));
        }

        public double Perimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public double Area()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return $"The rectangle's diagonal is: {this.Diagonal()}\nThe rectangle's perimeter is: {this.Perimeter()}\nThe rectangle's area is: {this.Area()}\n";
            ;
        }
    }
}
