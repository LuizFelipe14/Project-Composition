using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Globalization;
using Exercicio_Main.Entities;
using Exercicio_Main.Entities.Enums;


namespace Exercicio_Main {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's name: ");
            string dptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior, MidLevel, Senior): ");

            string lvl = Console.ReadLine();           
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), lvl, true);

            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(dptName);
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.WriteLine("How many contacts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {

                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");

                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.addContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            //Triming Month
            int month = int.Parse(monthAndYear.Substring(0, 2));
            //Triming Year
            int year = int.Parse(monthAndYear.Substring(3));


            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + " : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
