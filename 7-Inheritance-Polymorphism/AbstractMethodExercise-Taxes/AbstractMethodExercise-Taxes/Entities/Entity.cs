using System;

namespace AbstractMethodExercise_Taxes.Entities
{
    abstract class Entity
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Entity(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();

        public override string ToString()
        {
            return $"{Name}: $ {TaxesPaid():F2}";
        }
    }
}
