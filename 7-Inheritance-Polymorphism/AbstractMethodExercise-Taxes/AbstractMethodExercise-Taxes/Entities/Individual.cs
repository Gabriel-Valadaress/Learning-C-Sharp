using System;

namespace AbstractMethodExercise_Taxes.Entities
{
    class Individual : Entity
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double anualIncome, double healthExpenses) : base(name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TaxesPaid()
        {
            double taxesReduction;

            if (HealthExpenses > 0)
            {
                taxesReduction = HealthExpenses / 2;
            }
            else
            {
                taxesReduction = 0;
            }


            if (AnualIncome < 20000)
            {
                return AnualIncome * 0.15 - taxesReduction;
            }
            else
            {
                return AnualIncome * 0.25 - taxesReduction;
            }
        }
    }
}
