using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Emp Wage");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int Emp_Check = random.Next(0, 2);
            if (Emp_Check == IS_FULL_TIME) 
            {
                Console.WriteLine("Emp is present");
            }
            else { Console.WriteLine("Emp is Absent"); }
        }

    }

}
