using FirstClass_BasicInheritance.Entities;

namespace FirstClass_BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account bAcc = new BusinessAccount(1234, "Alex", 1000.00, 2000.00);
            Account sAcc = new SavingsAccount(0.01, 1235, "Jane", 5750.00);
            Account aAcc = new Account(1236, "Paul", 12.51);

            Console.WriteLine(bAcc);
            Console.WriteLine();
            Console.WriteLine(sAcc);
            Console.WriteLine();
            Console.WriteLine(aAcc);
        }
    }
}
