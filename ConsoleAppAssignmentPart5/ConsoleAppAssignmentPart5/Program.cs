using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        //Part 5
        //Create a list of strings that has at least two identical strings in the list.
        List<string> tables = new List<string>()
        {
            "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken"
        };
        Console.WriteLine("Welcome to Swell Taco! \nDue to Covid-19 we have a computerized check-in. \nIf you have a reservation type " +
            "\"Reserved\".\nIf you are joining a party that is already here type\"Taken\". \nOtherwise type \"Vacant\".");
        //Ask the user to select text to search for in the list.
        Console.WriteLine("Enter a Selection:");
        string selection = Console.ReadLine();
        while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
        {
            //Add code that tells a user if they put in the text that isn't in the list.
            Console.WriteLine("Please enter one of 3 choices:");
            selection = Console.ReadLine();
        }
        Console.WriteLine("The tables that match your selection are numbered:");
        //Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
        for (int i3 = 0; i3 < tables.Count; i3++)
        {
            if (selection == tables[i3])
            {
                Console.WriteLine(i3);
            }
        }
        Console.ReadLine();
    }
}

