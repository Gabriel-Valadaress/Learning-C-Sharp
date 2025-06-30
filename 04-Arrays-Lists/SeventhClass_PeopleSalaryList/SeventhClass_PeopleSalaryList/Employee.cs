using System;

namespace SeventhClass_PeopleSalaryList
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary (double percentege)
        {
            Salary *= 1 + percentege / 100;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: $ {Salary:F2}";
        }
    }
}
