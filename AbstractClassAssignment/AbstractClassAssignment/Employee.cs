using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create another class, "Employee" and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee Class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //Have your Employee class from the previous drill inherit and call the Quit()
        //method on it. 
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
