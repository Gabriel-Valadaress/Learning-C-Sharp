using AccountExercise.Entities;
using AccountExercise.Entities.Exceptions;

namespace AccountExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine(account);

                Console.Write("\nEnter amount for deposit: ");
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);

                Console.WriteLine(account);

                Console.Write("\nEnter amount for withdraw: ");
                amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);

                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Domain Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
