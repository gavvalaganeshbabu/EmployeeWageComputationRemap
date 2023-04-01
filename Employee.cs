using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int WagePerHour = 20;
        const int TotalHourPerDay = 8;
        const int PartTimeHour = 4;
        public  void IsEmployeePresent() {
            Console.WriteLine("Enter Employee Name :");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int attendence = rnd.Next(0, 3);
            switch (attendence)
            {
                case 0:
                    Console.WriteLine(name+"Absent Today and No Income Today :");
                    break;
                case 1:
                    Console.WriteLine(name + " Is Present Half Today ");
                    Console.WriteLine(PartTimeWageCalculator()+" Is Income Of Today :");
                    break;
                case 2:
                    Console.WriteLine(name + " Is Present Full day ");
                    Console.WriteLine(WagesPerDay() + " Is Income Today ");
                    break;
                default:
                    Console.WriteLine("invalid Option");
                    break;

            }
        }
        public int WagesPerDay() {
            int WageperDay = WagePerHour * TotalHourPerDay;
            return WageperDay;
        }
        public int PartTimeWageCalculator() {
            int WagePerHalfDay= PartTimeHour * WagePerHour;
            return WagePerHalfDay;
        }
    }
}
