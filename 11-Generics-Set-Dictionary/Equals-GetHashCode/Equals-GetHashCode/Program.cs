using Equals_GetHashCode.Entities;

namespace Equals_GetHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client() { Name = "Gabriel", Email = "gabriel@gmail.com" };

            Client client2 = new Client() { Name = "Maria", Email = "maria@gmail.com" };

            Console.WriteLine(client1.Equals(client2));

            Console.WriteLine(client1.GetHashCode() == client2.GetHashCode());
        }
    }
}
