using System;
namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int WorkingHrs;
            int perHrWage = 20;
            int totalWage;
            Random var = new Random();
            int empCheck = var.Next(0, 3);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is Working Full Time");
                WorkingHrs = 8;
            }
            else if (empCheck == 2)
            {
                Console.WriteLine("Employee is Doing Part Time");
                WorkingHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                WorkingHrs = 0;
            }
            totalWage = WorkingHrs * perHrWage;
            Console.WriteLine("So, Employee wage is: " + totalWage);
        }
    }
}
