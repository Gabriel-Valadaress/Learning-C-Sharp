using Composition_WorkersExercise.Entities.Enums;
using Composition_WorkersExercise.Entities;
using System.Xml.Linq;

namespace Composition_WorkersExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, workerLevel, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (YYYY-MM-DD): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HoursContract contract = new HoursContract(contractDate, valuePerHour, duration);
                worker.AddContract(contract);
            }
            
            Console.Write("Enter month and year to calculate income (YYYY-MM): ");
            DateTime filterDate = DateTime.Parse(Console.ReadLine() + "-01");
            Console.WriteLine($"Name: {worker.Name}\nDepartment: {worker.Department.Name}\nIncome for {filterDate.Month:D2}/{filterDate.Year}: {worker.Income(filterDate.Year, filterDate.Month)}");
        }
    }
}
