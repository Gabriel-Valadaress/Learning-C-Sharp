namespace SecondClass_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Registration

            Console.Write("Type your Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Type the Account Holder's Name: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Do you want to make a initial deposit? (y/n): ");

            Account account;
            char initialDepositQuestion = char.Parse(Console.ReadLine());
            if (initialDepositQuestion == 'y' || initialDepositQuestion == 'Y')
            {
                Console.Write("Type the value of the initial deposit: ");
                double initialDeposite = double.Parse(Console.ReadLine());
                account = new Account(accountNumber, accountHolder, initialDeposite);
            } else
            {
                account = new Account(accountNumber, accountHolder);
            }

            Console.WriteLine(account);

            //Deposit

            Console.Write("\nType the value of your deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            account.Deposit(deposit);

            Console.WriteLine(account);

            //Withdrawal

            Console.Write("\nType the value of your withdrawal: ");
            double withdrawal = double.Parse(Console.ReadLine());
            account.Withdrawal(withdrawal);

            Console.WriteLine(account);
        }
    }
}
