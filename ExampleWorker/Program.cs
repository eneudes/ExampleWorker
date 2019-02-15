using ExampleWorker.Entities;
using System;

namespace ExampleWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string nameDepartment = Console.ReadLine();
            Department department = new Department { Name = nameDepartment };
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLvel, Senior): ");
            string level = Console.ReadLine();
            Console.WriteLine("Base Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");

        }
    }
}
