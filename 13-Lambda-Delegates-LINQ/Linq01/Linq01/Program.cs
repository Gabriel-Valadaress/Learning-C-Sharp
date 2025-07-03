using System.Linq;

namespace Linq01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Data source
            int[] numbers = new int[] { 1, 2, 3, 4};

            //Query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
    