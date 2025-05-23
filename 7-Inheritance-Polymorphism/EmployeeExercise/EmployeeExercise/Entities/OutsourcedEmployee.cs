using System;

namespace EmployeeExercise.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; } = 1.1;

        public OutsourcedEmployee(string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
        }

        public override double Payment()
        {
            return base.Payment() * AdditionalCharge;
        }
    }
}
