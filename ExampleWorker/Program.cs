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
            Department department = new Department { Name = nameDepartment };

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            //Enum level = enum.parce(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Worker worker = new Worker(name, salary);
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
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculete income (MM/YYYY): ");
            DateTime dateIncome = DateTime.Parse(Console.ReadLine());
            //worker.Income(dateIncome.Year, dateIncome.Month);

            Console.WriteLine("Nome :"
                              + worker.Name 
                              + "Department: " 
                              + department.Name);
            Console.WriteLine(worker.Income(dateIncome.Year, dateIncome.Month););
        }
    }
}
