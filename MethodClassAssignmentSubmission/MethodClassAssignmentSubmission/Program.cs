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
            //Instantiate Class
            MathOperation1 math1 = new MathOperation1();
            //Call the method in the class, passing two numbers??????
            Console.WriteLine(math1.MathOp());
            //Call the method in the class, specifying the parameters by name ??????
            string seventyTwo = Convert.ToString(math1.MathOp()) ;
            string nine = Convert.ToString(math1.MathOp());
            Console.WriteLine(seventyTwo + nine);
            Console.ReadLine();
        }
    }
}
