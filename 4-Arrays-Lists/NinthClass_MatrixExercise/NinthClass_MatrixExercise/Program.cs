namespace NinthClass_MatrixExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program to read two integers, rowsQuantity and columnsQuantity, and then 
            read a matrix with rowsQuantity rows and columnsQuantity columns containing integers
            (values may repeat). Then, read an integer X that belongs to
            the matrix. For each occurrence of X, display the values to
            the left, above, right, and below X, when they exist.
             */

            Console.Write("Type the number of rows of the matrix: ");
            int rowsQuantity = int.Parse(Console.ReadLine());
            Console.Write("Type the number of columns of the matrix: ");
            int columnsQuantity = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsQuantity, columnsQuantity];
            
            for (int i = 0; i < rowsQuantity; i++)
            {
                Console.Write($"Type {columnsQuantity} values for the row number {i} separated by a space: ");
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < columnsQuantity; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
            Console.WriteLine("\nMatrix:");
            for (int i = 0; i < rowsQuantity; i++)
            {
                for (int j = 0; j < columnsQuantity; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("\nType a number to check its adjacent numbers: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string adjacentNumbers = "";

            for (int i = 0; i < rowsQuantity; i++)
            {
                for (int j = 0; j < columnsQuantity; j++)
                {
                    if (matrix[i,j] == number)
                    {
                        adjacentNumbers += $"Adjacent numbers position ({i}, {j}): ";
                        if (j != 0)
                        {
                            int left = matrix[i, j - 1];
                            adjacentNumbers += "Left: " + left + " ";
                        }
                        if (i != 0)
                        {
                            int above = matrix[i - 1, j];
                            adjacentNumbers += "Above: " + above + " ";
                        }
                        if (j != columnsQuantity - 1)
                        {
                            int right = matrix[i, j + 1];
                            adjacentNumbers += "Right: " + right + " ";
                        }
                        if (i != rowsQuantity - 1)
                        {
                            int below = matrix[i + 1, j];
                            adjacentNumbers += "  Below: " + below + " ";
                        }
                        adjacentNumbers += "\n";
                    }
                }
            }

            Console.WriteLine($"Values adjacent of {number}:\n" + adjacentNumbers);
        }
    }
}
