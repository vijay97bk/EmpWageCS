using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Emp Wage");
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHours = 0;
            int empWage = 0;

            Random random = new Random();
            int Emp_Check = random.Next(0, 3);
            if (Emp_Check == IS_PART_TIME)
            {
                empHours = 4;
            }
            else if (Emp_Check == IS_FULL_TIME) 
            {
                empHours = 8;
            }             
           else
            {
                empHours = 0;
            }
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine($"employee wage is {empWage}");
        }

    }

}
