using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //INside of the Main method, instantiate and initialize an Employee object with
            // the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Victorino", LastName = "Palacio" };
            //Call the superclass method sayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
