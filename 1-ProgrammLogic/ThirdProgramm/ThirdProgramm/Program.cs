namespace ThirdProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Gabriel";

            char[] arr = name.ToCharArray();

            string backward = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                backward += arr[i];
            }

            Console.WriteLine(backward);
        }
    }
}
