namespace ThirdClass_AvarageSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The programm must calculate the avarage of the salary of 2 employee

            Employee firstEmployee = new Employee();
            Employee secondEmployee = new Employee();

            Console.WriteLine("Data of the first employee:");
            Console.Write("Name: ");
            firstEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            firstEmployee.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Data of the second employee:");
            Console.Write("Name: ");
            secondEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            secondEmployee.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Avarage Salary: {firstEmployee.AvarageSalary(secondEmployee)}");
        }
    }
}
