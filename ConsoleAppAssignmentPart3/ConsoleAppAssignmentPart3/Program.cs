using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
static void Main(string[] args)
    {
        //Part 3
        Console.WriteLine("Is that a ghost?!");
        StringBuilder boo = new StringBuilder();
        boo.Append("B");
        //Create a loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator.
        while (boo.Length < 10)
        {
            boo.Append("o");
        }
        boo.Append("!");
        Console.ReadLine();
        Console.WriteLine(boo);
        Console.ReadLine();
        StringBuilder ahh = new StringBuilder();
        ahh.Append("A");
        //Add a loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator.
        while (ahh.Length <= 10)
        {
            ahh.Append("h");
        }
        ahh.Append("!");
        Console.WriteLine(ahh);
        Console.ReadLine();
    }
}

