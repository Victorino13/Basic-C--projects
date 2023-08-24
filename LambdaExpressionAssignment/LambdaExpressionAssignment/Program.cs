using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {Id = 1, FirstName = "Joe", LastName = "Schmo"},
                new Employee() {Id = 2, FirstName = "Joe", LastName = "Thomas"},
                new Employee() {Id = 3, FirstName = "Kam", LastName = "Mango"},
                new Employee() {Id = 4, FirstName = "Meli", LastName = "Red"},
                new Employee() {Id = 5, FirstName = "Rolen", LastName = "July"},
                new Employee() {Id = 6, FirstName = "Summer", LastName = "None"},
                new Employee() {Id = 7, FirstName = "Isa", LastName = "Lolen"},
                new Employee() {Id = 8, FirstName = "Ken", LastName = "Kumar"},
                new Employee() {Id = 9, FirstName = "Kyle", LastName = "leli"},
                new Employee() {Id = 10, FirstName = "Denver", LastName = "Round"},
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                joes.Add(employee);
            }

            //Do the same thing again, but this time with a lamba expression.
            List<Employee> joes2 = campus.Where(x => x.FirstName == "Joe").ToList();

            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
        
    }
}
