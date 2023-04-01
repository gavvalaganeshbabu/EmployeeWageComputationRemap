using System;

namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Project : ");
            Console.WriteLine("Enter Employee Name :");
            string name=Console.ReadLine();
            Employee employee= new Employee();
            string b = employee.IsEmployeePresent();
            if (b == "Full Day Present") {
                Console.WriteLine(name + " Is Present Today ");
                int WagePerDay=employee.WagesPerDay();
                Console.WriteLine(WagePerDay+" Is the Total Wages Per Day ");
            }
            else if(b== "Part Time Present")
            {
                Console.WriteLine(name + " Is Present Half Today ");
                int WagePerHalfDay = employee.PartTimeWageCalculator();
                Console.WriteLine(WagePerHalfDay + " Is Total Wage Today ");
            }
            else { Console.WriteLine(name + "Is Absent Today And No Income Today ");
            }
            Console.ReadLine();
        }

        
    }
}
