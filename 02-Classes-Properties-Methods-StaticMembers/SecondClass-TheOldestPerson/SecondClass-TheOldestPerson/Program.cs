namespace SecondClass_TheOldestPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compare the age of two people

            Person first = new Person();
            Person second = new Person();

            Console.WriteLine("Data of the first person:");
            Console.Write("Name: ");
            first.Name = Console.ReadLine();
            Console.Write("Age: ");
            first.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Data of the second person:");
            Console.Write("Name: ");
            second.Name = Console.ReadLine();
            Console.Write("Age: ");
            second.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(first.AgeComparison(second));
        }
    }
}
