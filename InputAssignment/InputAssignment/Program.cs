using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            //Logs the number to a text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Vppal\Documents\logs\lognum.txt", true))
            {
                file.WriteLine(number);
            }
            //prints text file back to user
            Console.WriteLine(number);
            Console.ReadLine();
            
            
        }
    }
}
