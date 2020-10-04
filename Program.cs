﻿using System;

namespace EmployeeWageTillUC7
{
    class Program
    {
        /// <summary>
        /// Parts the time employee daily wage.
        /// </summary>
        /// <returns></returns>
        public static float PartTimeEmployeeDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int partDayHour = 4;
            Random random = new Random();
            // Above randoom variable is to know part time or full time
            int partTime = random.Next(0, 2);
            if (partTime == 0)
            {
                return wagePerHour * partDayHour;
            }
            else
            {
                return wagePerHour * fullDayHour;
            }
        }
        /// <summary>
        /// Employees the daily wage.
        /// </summary>
        /// <returns></returns>
        public static float EmployeeDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            Random random = new Random();
            // A random object variable used to assign the time contribution of an employee
            int fullTime = random.Next(0, 2);
            if (fullTime == 1)
            {
                return wagePerHour * fullDayHour;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public static void Display()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");
        }
        /// <summary>
        /// Employees the attendance.
        /// </summary>
        /// <returns></returns>
        public static int EmployeeAttendance()
        {
            // Assigning a Random variable of 2 value range to check if the employee is present or absent
            Random random = new Random();
            int flag = random.Next(0, 2);
            if (flag == 1)
            {
                Console.WriteLine("The Employee is Present");
                return flag;
            }
            else
            {
                Console.WriteLine("The Employee is Absent");
                return flag;
            }
        }
        static void Main(string[] args)
        {
            // Calling the static Function Display
            Display();
            // Calling the static Function Employee Attendance
            EmployeeAttendance();
            // Calling the static function to Compute the daily wage for a full time employee
            Console.WriteLine(EmployeeDailyWage());
            // Calling the static function to Compute the daily wage for a Part time employee
            Console.WriteLine(PartTimeEmployeeDailyWage());
        }
    }
}
