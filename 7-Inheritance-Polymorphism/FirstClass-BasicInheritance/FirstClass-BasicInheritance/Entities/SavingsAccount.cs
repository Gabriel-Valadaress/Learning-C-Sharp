using System;

namespace FirstClass_BasicInheritance.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRates { get; set; } 

        public SavingsAccount() { }
        public SavingsAccount(double interestRates, int number, string holder, double balance) : base(number, holder, balance)
        {
            InterestRates = interestRates;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRates;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nInterest Rates: {InterestRates * 100}%";
        }
    }
}
