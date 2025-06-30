using AbstractMethodExercise_Shapes.Entities;
using AbstractMethodExercise_Shapes.Entities.Enums;

namespace AbstractMethodExercise_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShape = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShape; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeResponse = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shapeResponse == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Shape shape = new Rectangle(width, height, color);
                    shapes.Add(shape);
                }

                if (shapeResponse == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape shape = new Circle(radius, color);
                    shapes.Add(shape);
                }
            }

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
