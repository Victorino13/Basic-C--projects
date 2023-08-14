using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate class
            MathOperation1 mathOp = new MathOperation1();
            //Enter first integer
            Console.WriteLine("Enter first integer");
            int num1 = 8 * Convert.ToInt32(Console.ReadLine());
            //Enter second integer
            Console.WriteLine("Enter second integer");
            int num2 = Convert.ToInt32(Console.ReadLine());
            mathOp.MathOperation(num1, num2);
            Console.WriteLine();
            //Call the method in class, specifying the parameters by name
            mathOp.MathOperation(num1, num2);
            Console.WriteLine("num1 is 8 times first integer = " + num1 + " and num2 is = " + num2);
            Console.ReadLine();
        }
    }
}
