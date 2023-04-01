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
            }
            else { Console.WriteLine(name + " Is Absent Today ");
            }
        }

        
    }
}
