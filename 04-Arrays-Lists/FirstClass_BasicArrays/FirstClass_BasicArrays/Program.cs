namespace FirstClass_BasicArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many heights do you want to type to calculate the avarage height? ");
            int quantity = int.Parse(Console.ReadLine());

            double[] arr = new double[quantity];
            double avg = 0;
            
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("Type the height: ");
                arr[i] = double.Parse(Console.ReadLine());
                avg += arr[i];
            }

            avg = avg / quantity;

            Console.WriteLine($"The avarage is: {avg:F2}");
        }
    }
}
