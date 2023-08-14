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
            //Call the method in class, passing two numbers
            //Call the method in class, specifying the parameters by name
            mathOp.MathOperation();
            Console.ReadLine();
        }
    }
}
