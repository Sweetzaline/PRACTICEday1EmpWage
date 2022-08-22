using System;
namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
            }
        }
    }
}