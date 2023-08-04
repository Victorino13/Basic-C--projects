using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code prints the title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            
            // This block of code is dedicated for Person 1 to provide his/her hourly rate and hours worked per week.
            Console.WriteLine("Person 1");
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hours worked per week?");
            int weeklyHours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // This block of code is dedicated for Person 2 to provide his/her hourly rate and hours worked per week.
            Console.WriteLine("Person 2");
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hours worked per week?");
            int weeklyHours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // This block of code prints the Annual Salary of Person 1
            Console.WriteLine("Annual Salary of Person 1:");
            decimal Sal1 = Convert.ToDecimal(weeklyHours1 * hourlyRate1 * 52);
            Console.WriteLine(Sal1);
            Console.WriteLine();

            // This block of code prints the Annual Salary of Person 2
            Console.WriteLine("Annual Salary of Person 2:");
            decimal Sal2 = Convert.ToDecimal(weeklyHours2 * hourlyRate2 * 52);
            Console.WriteLine(Sal2);
            Console.WriteLine();

            // This block of code prints if Person 1 makes more than Person 2 and determines if it is true of false.
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool trueOrFalse = Sal1 > Sal2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
