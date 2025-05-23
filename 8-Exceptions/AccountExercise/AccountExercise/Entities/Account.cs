using System;
using AccountExercise.Entities.Exceptions;

namespace AccountExercise.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("The deposit must be a positive number!");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("The withdraw must be a positive number!");
            }

            if (amount > Balance)
            {
                throw new Exception("The withdraw can't be higher than the balance!");
            }

            if (amount > WithdrawLimit)
            {
                throw new Exception("The amount to withdraw can't be higher than the withdraw limit!");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"\nAccount number: {Number}\nAccount holder: {Holder}\nAccount balance: {Balance}\nWithdraw Limit: {WithdrawLimit}";
        }
    }
}
