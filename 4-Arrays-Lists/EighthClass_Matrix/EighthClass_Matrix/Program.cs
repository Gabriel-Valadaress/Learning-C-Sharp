namespace EighthClass_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rows/columns do you want the matrix to have? ");
            int quantity = int.Parse(Console.ReadLine());
            int[,] matrix = new int[quantity,quantity];
            int negativeNumberQuantity = 0;


            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Type {quantity} int numbers separated by a space: ");
                string numbers = Console.ReadLine();
                string[] row = numbers.Split(" ");      
                
                for (int j = 0; j < quantity; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                    if (matrix[i,j] < 0)
                    {
                        negativeNumberQuantity++;
                    }
                }
            }

            Console.WriteLine("\nMain diagonal");
            for (int i = 0; i < quantity; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }

            Console.WriteLine($"\nQuantity of negative numbers: {negativeNumberQuantity}");
        }
    }
}
