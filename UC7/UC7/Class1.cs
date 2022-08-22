using System;
namespace UC7
{
    class Class1
    {
        public static void CalculateteWage()
        {
            int Day = 0;
            int WorkingHrs = 0;
            int perHrWage = 20;
            int tempWorkingHr;
            int Wage;
            int totalWage = 0;
            while (WorkingHrs <= 100 && Day < 20)
            {
                Random var = new Random();
                int empCheck = var.Next(0, 3);
                Day++;
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is Working Full Time");
                        tempWorkingHr = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Doing Part Time");
                        tempWorkingHr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        tempWorkingHr = 0;
                        break;
                }
                WorkingHrs = +tempWorkingHr;
                Wage = WorkingHrs * perHrWage;
                Console.WriteLine("Day" + Day + ": Employee wage is:" + Wage + "\n");
                totalWage = totalWage + Wage;
            }
            Console.WriteLine("So, Total wage of the employee in a month is: " + totalWage);
        }
    }
}
