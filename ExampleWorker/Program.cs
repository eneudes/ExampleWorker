using ExampleWorker.Entities;
using ExampleWorker.Entities.Enums;
using System;
using System.Globalization;

namespace ExampleWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string nameDepartment = Console.ReadLine();     
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // instantiating objects
            Department department = new Department(nameDepartment);
            Worker worker = new Worker(name, level, salary, department);
            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int amount = int.Parse(Console.ReadLine());

            for(int i = 1; i <= amount; i++)
            {
                Console.WriteLine("Enter #" + i + "contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, value, duration);
                worker.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculete income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome :" + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for" + monthAndYear + ": " + worker.Income(year, month));
            
        }
    }
}
