using System;

namespace SecondClass_BankAccount
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        public Account(int accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public void Withdrawal (double withdrawal)
        {
            Balance -= (withdrawal + 5);
        }

        public override string ToString()
        {
            return $"\nAccount Information:\nAccount Number: {AccountNumber}\nAccount holder's name: {AccountHolder}\nBalance: $ {Balance:F2}";
        }
    }
}
