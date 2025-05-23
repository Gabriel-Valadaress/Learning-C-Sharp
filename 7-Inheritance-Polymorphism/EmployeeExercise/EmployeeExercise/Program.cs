using EmployeeExercise.Entities;

namespace EmployeeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Employee Registration:");
            Console.Write("How many employees do you want to register? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee Registration {i}/{numberEmployees}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int workedHours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Is the employee outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Employee employee;

                if (outsourced == 'y')
                {
                    employee = new OutsourcedEmployee(name, workedHours, valuePerHour);
                }
                else
                {
                    employee = new Employee(name, workedHours, valuePerHour);
                }
                employees.Add(employee);
            }

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
