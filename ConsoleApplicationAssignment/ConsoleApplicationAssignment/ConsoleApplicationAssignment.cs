using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code takes a number from user and will be multiplied by 50.
            Console.WriteLine("Enter a number that will be multiplied by fifty");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product = Convert.ToInt32(num1 * 50);
            Console.WriteLine(num1 + " multiplied by 50 =" + product);

            // This code takes a number from user and 25 will be added.
            Console.WriteLine("Enter a number that will be added to twenty five");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int total = Convert.ToInt32(num2 + 25);
            Console.WriteLine(num2 + " plus 25 =" + total);

            //This code takes a number from user and will be divided by 12.5.
            Console.WriteLine("Enter a number that will be divided by 12.5");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int qoutient = Convert.ToInt32(num3 / 12.5);
            Console.WriteLine(num3 + " divided by 12.5= " + qoutient);

            //This code takes a number from user and determines if it is greater that 50.
            Console.WriteLine("Enter a number and know if it is greater than 50");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(trueOrFalse.ToString());

            Console.WriteLine("Enter a number that will be divided by 7. It will show the remainder");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine("The remainder is " + remainder);
            Console.ReadLine();

      
        }
    }
}
