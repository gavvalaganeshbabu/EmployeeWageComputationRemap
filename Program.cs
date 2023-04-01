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
            bool b = employee.IsEmployeePresent();
            if (b == true) {
                Console.WriteLine(name + " Is Present Today ");
                int WagePerDay=employee.WagesPerDay();
                Console.WriteLine(WagePerDay+" Is the Total Wages Per Day ");
            }
            else {
                Console.WriteLine(name + " Is Absent Today ");
                Console.WriteLine("No Income Today ");
            }
            Console.ReadLine();
        }

        
    }
}
