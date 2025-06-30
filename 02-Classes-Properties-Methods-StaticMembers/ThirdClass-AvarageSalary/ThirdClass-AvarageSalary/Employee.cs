using System;

namespace ThirdClass_AvarageSalary
{
    class Employee
    {
        public string Name;
        public double Salary;

        public double AvarageSalary (Employee otherEmployee)
        {
            return (this.Salary + otherEmployee.Salary)/2;
        }
    }
}
