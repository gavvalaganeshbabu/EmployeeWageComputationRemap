using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int WagePerHour = 20;
        const int TotalHourPerDay = 8;
        public  bool IsEmployeePresent() {
            Random rnd = new Random();
            int attendence = rnd.Next(0, 2);
            if(attendence==0)
            return false;
            else return true;
        }
        public int WagesPerDay() {
            int WageperDay = WagePerHour * TotalHourPerDay;
            return WageperDay;
        }
    }
}
