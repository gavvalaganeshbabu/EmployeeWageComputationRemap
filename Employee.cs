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
        const int TotalWorkingDaysPerMonth = 20;
        public int TotalWageOfMonth;
        public int WorkingDays=20;
        const int TotalWorkingHours = 100;
        public int TotalHours = 0;
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
        public void TotalWagePerMonth() {
            Random random= new Random();
            for (int i = 0; i <= TotalWorkingDaysPerMonth; i++)
            {
                int n = random.Next(0, 3);
                switch (n)
                {
                    case 0://Full Day present
                        TotalWageOfMonth += (TotalHourPerDay * WagePerHour);
                        break;
                    case 1://Half Day Present
                        TotalWageOfMonth += (PartTimeHour * WagePerHour);
                        break;
                    case 2://Full Day Absent
                        WorkingDays--;
                        TotalWageOfMonth += 0;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No of Working Days in Month = " + WorkingDays);
            Console.WriteLine("Total Wages in a Month = " + TotalWageOfMonth);
        }
        public void TotalWagePerMonthMaximum()
        {
            Random rnd = new Random();
            for (int i = 0; TotalHours <= TotalWorkingHours; i++)
            {
                int n = rnd.Next(0, 3);
                switch (n)
                {
                    case 0://Full Day present
                        TotalHours += TotalHourPerDay;
                        TotalWageOfMonth += (TotalHourPerDay * WagePerHour);
                        break;
                    case 1://Half Day Present
                        TotalHours += PartTimeHour;
                        TotalWageOfMonth += (PartTimeHour * WagePerHour);
                        break;
                    case 2://Full Day Absent
                        WorkingDays--;
                        TotalWageOfMonth += 0;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Total Working Hours = " + TotalHours);
            Console.WriteLine("No of Working Days in Month = " + WorkingDays);
            Console.WriteLine("Total Wages in a Month = " + TotalWageOfMonth);
        }

    }
}
