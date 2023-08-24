using System;
using ExercicioWork.Entitites.Enums;
using System.Globalization;
using ExercicioWork.Entitites;


namespace ExercicioWork // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departments name: ");
            string deptName =Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior | MIdLevel | Senior)");
            WorkerLevel level  = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary,dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} constract data:");
                Console.WriteLine("Date DD/MMYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours:");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date,  valuePerHour,  hours);

                worker.AddContract(contract);

            }

            Console.WriteLine("Enter month an year (MM/YYYY):");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Name: " + worker.Department.Name) ;
            Console.WriteLine("Income for: " + monthAndYear +": "+ worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}