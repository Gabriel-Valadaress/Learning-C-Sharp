namespace FifthClass_RectangleInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Type the information of the rectangle:");
            Console.Write("Width: ");
            rectangle.Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            rectangle.Height = double.Parse(Console.ReadLine());

            Console.WriteLine(rectangle);
        }
    }
}
