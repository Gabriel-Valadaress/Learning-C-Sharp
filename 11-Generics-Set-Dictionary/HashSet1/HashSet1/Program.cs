namespace HashSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("John");
            set.Add("Mary");
            set.Add("Paul");
            set.Add("Bob");
            set.Add("Peter");
            set.Add("Jane");

            Console.WriteLine(set.Contains("John"));
            Console.WriteLine(set.Contains("Anne"));

            Console.WriteLine("--------------------");

            foreach (string person in set)
            {
                Console.WriteLine(person);
            }

        }
    }
}
