namespace SortedSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> group1 = new SortedSet<string>() { "Mary", "Paul", "John", "Anne" };
            SortedSet<string> group2 = new SortedSet<string>() { "Jason", "Mary", "Anne", "Bill" };

            Console.WriteLine("Group1:");
            printCollection(group1);

            Console.WriteLine("----------------------");

            Console.WriteLine("Group2:");
            printCollection(group2);

            Console.WriteLine("----------------------");

            SortedSet<string> group3 = new SortedSet<string>(group1);
            group3.UnionWith(group2);

            Console.WriteLine("Group1 union with group2:");
            printCollection(group3);

            Console.WriteLine("----------------------");

            SortedSet<string> group4 = new SortedSet<string>(group1);
            group4.IntersectWith(group2);

            Console.WriteLine("Group1 intersect with group2:");
            printCollection(group4);

            Console.WriteLine("----------------------");

            SortedSet<string> group5 = new SortedSet<string>(group1);
            group5.ExceptWith(group2);

            Console.WriteLine("Group1 except with group2:");
            printCollection(group5);

            Console.WriteLine("----------------------");

        }

        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
