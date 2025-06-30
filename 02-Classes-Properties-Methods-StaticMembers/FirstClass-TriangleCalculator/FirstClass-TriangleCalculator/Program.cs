namespace FirstClass_TriangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compare de area of 2 triangles

            Triangle x = new Triangle();
            Triangle y = new Triangle();

            Console.WriteLine("Type the dimensions of the 3 sides of the first triangle:");
            x.SideA = double.Parse(Console.ReadLine());
            x.SideB = double.Parse(Console.ReadLine());
            x.SideC = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the dimensions of the 3 sides of the second triangle:");
            y.SideA = double.Parse(Console.ReadLine());
            y.SideB = double.Parse(Console.ReadLine());
            y.SideC = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of the first triangle: {x.Area():F2}");
            Console.WriteLine($"The area of the second triangle: {y.Area():F2}");

            if (x.Area() > y.Area())
            {
                Console.WriteLine($"The first triangle is bigger than the second triangle!");
            }
            else if (x.Area() < y.Area())
            {
                Console.WriteLine($"The second triangle is bigger than the first triangle!");
            } else
            {
                Console.WriteLine("The area of both triangles are the same!");
            }
        }
    }
}
