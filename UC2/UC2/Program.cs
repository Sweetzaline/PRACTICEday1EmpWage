using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullDayHrs = 8;
            int perHrWage = 20;
            int totalWage;
            Random var = new Random();
            int empCheck = var.Next(0, 2);
            if(empCheck == 1)
            {
                Console.WriteLine("Employee is Present");
                totalWage = fullDayHrs * perHrWage;
                Console.WriteLine("One day employee wage is: " + totalWage );
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("No Wage for Absentee.");
            }
            
        }
    }
}
