using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age
            //Display the year the user was born.
            //Exceptions must be handled using try/catch
            //Display appropriate error messages if the user enters zero or negative numbers.
            //Display a general message if an exception was caused by anything else.

            try
            {
                Console.WriteLine("Please enter your Age");
                int userAge = int.Parse(Console.ReadLine());
                int yearBorn = 2023 - userAge;
                Console.WriteLine(yearBorn);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter Age no less than 1");
            }
            catch
            {
                Console.WriteLine("Please contact System Administrator");
            }
            Console.ReadLine();







        }
    }
}


