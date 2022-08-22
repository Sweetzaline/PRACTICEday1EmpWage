using System;
namespace UC9
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Dmart = new Class1("Dmart", 20, 3, 100);
            Class1 Max = new Class1("Max", 40, 3, 400);

            Dmart.CalculateWage();
            Max.CalculateWage();
        }
    }
    public class Class1
    {
        private string company;
        private int perHrWage;
        private int maxWorkingDays;
        private int maxWorkingHr;
        private int Wage;

        public Class1(string company, int perHrWage, int maxWorkingDays, int maxWorkingHr)//Copy Constructor
        {
            this.company = company;
            this.perHrWage = perHrWage;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHr = maxWorkingHr;
        }
        public void CalculateWage()
        {
            int TotalWorkingHr = 0, WorkingDay = 1, WorkingHrs, totalWage = 0;

            while (TotalWorkingHr <= maxWorkingHr && WorkingDay < maxWorkingDays)
            {
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
                Wage = WorkingHrs * perHrWage;
                Console.WriteLine("Day" + WorkingDay + "Employee wage is:" + Wage + "\n");
                WorkingDay++;
                totalWage = totalWage + Wage;
                TotalWorkingHr = TotalWorkingHr + WorkingHrs;
            }
            Console.WriteLine("\nFor " + this.company + " Company, Total employee working hour is:" + TotalWorkingHr + ". & Total wage is:" + totalWage + "\n");
        }
    }
}