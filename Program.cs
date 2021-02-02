﻿using System;

namespace EmpWage
{
    class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
          
            int empHours = 0;
            int empWage = 0;

            Random random = new Random();
            int Emp_Check = random.Next(0, 3);
            switch (Emp_Check)
            {
                case IS_PART_TIME:
                    empHours = 4;
                    break;
                case IS_FULL_TIME:
                    empHours = 8;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            empWage = (empHours * EMP_RATE_PER_HOUR);
            Console.WriteLine("employee wage is" + empWage);
        }

    }

}
