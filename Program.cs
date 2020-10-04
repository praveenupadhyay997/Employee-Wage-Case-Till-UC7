using System;

namespace EmployeeWageTillUC7
{
    class Program
    {
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
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=============================================");
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("=============================================");

            EmployeeDailyWage();
        }
    }
}
