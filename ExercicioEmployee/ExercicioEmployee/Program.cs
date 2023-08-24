using System.Collections.Generic;
using System;
using ExercicioEmployee.Entities;
using System.Globalization;

namespace ExercicioEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} ");
                Console.Write("Outsourced(y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePeHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name,hours,valuePeHour,additionalCharge));

                }
                else
                {
                    list.Add(new Employee(name,hours,valuePeHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");

            foreach( Employee emp in list ) {

                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }



        }
    }
}