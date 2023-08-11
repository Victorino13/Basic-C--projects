using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Part 6
        //Create a list of strings that has at least two identical strings in the list.
        List<string> names = new List<string>()
        {
            "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary"
        };
        List<string> repeatCheck = new List<string>();
        Console.WriteLine("Class Roster:");
        //Create a for eachloop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        foreach (string name in names)
        {
            Console.WriteLine(name);
            if (repeatCheck.Contains(name))
            {
                Console.WriteLine("This name has been repeated. \nUse last name initial when referring to this student.");
            }
            else
            {
                Console.WriteLine("This name has not been repeated.");
            }
            repeatCheck.Add(name);
        }
        Console.ReadLine();
    }
}

    


