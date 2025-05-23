using System;

namespace AbstractMethodExercise_Taxes.Entities
{
    class Company : Entity
    {
        public int EmployeesQuantity { get; set; }

        public Company(string name, double anualIncome, int employeesQuantity) : base(name, anualIncome)
        {
            EmployeesQuantity = employeesQuantity;
        }

        public override double TaxesPaid()
        {
           if (EmployeesQuantity <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
