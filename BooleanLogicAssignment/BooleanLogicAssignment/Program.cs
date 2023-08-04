using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();
            bool dui = answer == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age > 15) && !dui && (ticket <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();

            
            
        }
    }
}
