using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignmentSubmission
{
    //Create Employee class with Id, FirstName and LastName properties
    public class Employee
    {
        public string empA, empB;
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee empA, Employee empB)
        {
            return (empA.Id == empB.Id);
        }
        public static bool operator!= (Employee empA, Employee empB)
        {
            return (empA.Id != empB.Id);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
  
    
    
}
