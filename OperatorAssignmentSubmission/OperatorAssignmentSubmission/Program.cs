using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the Program.cs file, instantiate two objects of the employee class and assign values
            //to their properties. Then compare the two Employee objects using the newly overloaded operators
            //and display the results.
            Employee empA = new Employee();
            empA.Id = "1001";
            empA.FirstName = "Victorino";
            empA.LastName = "Palacio";
            
            Employee empB = new Employee();
            empB.Id = "1002";
            empB.FirstName = "Jeff";
            empB.LastName = "Quitevis";

            Console.WriteLine(empA.Id != empB.Id);
            Console.WriteLine(empA.Id == empB.Id);
            Console.ReadLine();
            
            
           

        }
    }
}
