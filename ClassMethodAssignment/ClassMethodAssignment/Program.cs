using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main() method, instantiate the class
            VoidMethod math = new VoidMethod();
            //Call the void method
            Console.WriteLine("Input a number");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MathOp(dividend);
            Console.WriteLine(math.Value);
            Console.ReadLine();
            //Call the method with output parameters
            Console.WriteLine("Input a phrase");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();
            //Call the overloaded method
            Console.WriteLine("Input another phrase");
            string input2 = Console.ReadLine();
            int phrase2_len = math.StringCounter(input2);
            Console.WriteLine("This phrase is " + phrase2_len + " characters long");
            Console.ReadLine();
            //Call the method of the static class
            Console.WriteLine("input another phrase:");
            string input3 = Console.ReadLine();
            int i_count = VoidMethod.Ifinder(input3);
            Console.WriteLine("This phrase has " + i_count + " i's in it.");
            Console.ReadLine();
        }
    }
}
