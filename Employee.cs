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
        public  string IsEmployeePresent() {
            Random rnd = new Random();
            int attendence = rnd.Next(0, 3);
            if (attendence == 0)
                return "Absent ";
            else if (attendence == 1) return "Part Time Present";
            else
                return "Full Day Present";
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
