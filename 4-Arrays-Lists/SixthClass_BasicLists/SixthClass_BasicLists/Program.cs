using System.Collections.Generic;

namespace SixthClass_BasicLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Mary");
            list.Add("John");
            list.Insert(1, "Alex");
            list.Add("Tim");
            list.Add("Antony");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            int namesInTheList = list.Count;
            Console.WriteLine($"\nNumber of names in the list: {namesInTheList}");

            string firstA = list.Find(name => name[0] == 'A');
            int positionFirstA = list.FindIndex(name => name[0] == 'A');
            Console.WriteLine($"\nThe first name in the list that starts with the letter 'A' is: {firstA}. Number {positionFirstA + 1} of the list.");

            string lastA = list.FindLast(name => name[0] == 'A');
            int positionLastA = list.FindLastIndex(name => name[0] == 'A');
            Console.WriteLine($"\nThe last name in the list that starts with the letter 'A' is: {lastA}. Number {positionLastA + 1} of the list.");

            List<string> fourCharactersName = list.FindAll(name => name.Length == 4);
            Console.WriteLine("\nNames with 4 characteres:");

            foreach (string obj in fourCharactersName)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
