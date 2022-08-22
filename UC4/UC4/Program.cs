using System;
namespace UC4
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
            switch (empCheck)
            {
                case 1:
                Console.WriteLine("Employee is Working Full Time");
                WorkingHrs = 8;
                    break;
                case 2:
                Console.WriteLine("Employee is Doing Part Time");
                WorkingHrs = 4;
                    break;
                default:            
                Console.WriteLine("Employee is Absent");
                WorkingHrs = 0;
                    break;
            }
            totalWage = WorkingHrs * perHrWage;
            Console.WriteLine("So, Employee wage is: " + totalWage);
        }
    }
}
