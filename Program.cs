﻿using System;

namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Project : ");
            
            Employee employee= new Employee();
            employee.IsEmployeePresent();
            Console.ReadLine();
        }

        
    }
}
