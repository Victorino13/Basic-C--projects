using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    public class Person
    {
        //create a class called Person and give it two properties, each of data type string
        //One called FirstName and other one is LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called sayName() that takes no parameters and simply writes
        //the person's full name to the console in the format of: "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }


    }

    // Create another class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        //Give the Employee class a property called Id and have it be of data type int
        public int Id { get; set; }

    }
}
