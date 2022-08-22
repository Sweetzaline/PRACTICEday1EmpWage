using System;
namespace UC10
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Class4 obj = new Class1.Class4();
            obj.addCompanyWage("DMart", 50, 25, 1250);
            obj.addCompanyWage("Max", 20, 30, 600);
            obj.computeWage();
        }
    }
    public class Class1
    {
        public string company;
        public int empWageperHr;
        public int WorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        
        public Class1(string company, int empWageperHr, int WorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empWageperHr = empWageperHr;
            this.WorkingDays = WorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        } 
        public void Class2(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string Class3()
        {
            return "Total Emp Wage for Company: " + this.company + "is:" + this.totalEmpWage +"\n";
        }
        public class Class4
        {
            public const int Is_Part_Time = 1;
            public const int Is_Full_Time = 2;

            private int numOfCompany = 0;
            public Class1[] CompanyEmpWageArray;
            public Class4()
            {
                this.CompanyEmpWageArray = new Class1[5];
            }
            public void addCompanyWage(string company, int empWageperHr, int WorkingDays, int maxHoursPerMonth)
            {
                CompanyEmpWageArray[this.numOfCompany] = new Class1(company, empWageperHr, WorkingDays, maxHoursPerMonth);
                numOfCompany++;
            }
            public void computeWage()
            {
                for (int i= 0; i< numOfCompany; i++)
                {
                    CompanyEmpWageArray[i].Class2(this.computeWage(this.CompanyEmpWageArray[i]));
                    Console.WriteLine(this.CompanyEmpWageArray[i].Class3());
                }
            }
            private int computeWage(Class1 b)
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDay = 0;

                while (totalEmpHrs <= b.maxHoursPerMonth && totalWorkingDay < b.WorkingDays)
                {
                    totalWorkingDay++;
                    Random var = new Random();
                    int empCheck = var.Next(0, 3);

                    switch (empCheck)
                    {
                        case 1:
                            Console.WriteLine("Employee is Working Full Time");
                            empHrs = 8;
                            break;
                        case 2:
                            Console.WriteLine("Employee is Doing Part Time");
                            empHrs = 4;
                            break;
                        default:
                            Console.WriteLine("Employee is Absent");
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs = totalEmpHrs + empHrs;
                    Console.WriteLine("Day" + totalWorkingDay + "Employee Hour is:" + empHrs + "\n");
                }
                return totalEmpHrs * b.empWageperHr;

            }
        }
    }
}
