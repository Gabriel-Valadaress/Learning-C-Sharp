using System.Collections.Generic;

namespace SeventhClass_PeopleSalaryList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Create a program to read an integer N and then read the data (id, name, and salary)
            of N employees. There must be no repetition of ids.

            Next, perform a salary increase of X percent for a given employee. To do this, the 
            program must read an id and the value X. If the given id does not exist, display a 
            message and abort the operation. At the end, display the updated list of employees, 
            as shown in the examples.

            Remember to apply the encapsulation technique to prevent the salary from being changed 
            freely. A salary can only be increased through an operation based on a given percentage. 
            
             */

            Console.Write("Do you want to register a Employee? (y/n) ");
            char quantity = char.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            while (quantity == 'y')
            {
                Console.Write("What is the employee id? ");
                int id = int.Parse(Console.ReadLine());

                Employee foundEmployee = employees.Find(emp => emp.Id == id);

                if (foundEmployee == null)
                {
                    Console.Write("What is the employee name? ");
                    string name = Console.ReadLine();
                    Console.Write("What is the employee salary? ");
                    double salary = double.Parse(Console.ReadLine());

                    employees.Add(new Employee(id, name, salary));
                }
                else
                {
                    Console.WriteLine("Id already registered!");
                }

                Console.Write("Do you want to register another Employee? (y/n) ");
                quantity = char.Parse(Console.ReadLine());
            }

            foreach(Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
