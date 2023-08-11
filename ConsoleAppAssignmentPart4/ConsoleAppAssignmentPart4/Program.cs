using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Part 4
        //Create a list of strings where each item in the list is unique.
        List<string> teams = new List<string>()
        {
            "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
            "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers"
        };
        Console.WriteLine("NBA Eastern Conference Standings");
        //Ask the user to input text to search for in the List.
        Console.WriteLine("Enter team name:");
        int standing = 0;
        bool isValid = false;
        int index = 0;
        //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
        while (!isValid)
        {
            int i2 = 0;
            string teamrequest = Console.ReadLine();
            foreach (string team in teams)
            {
                if (teamrequest == team)
                {
                    standing = i2 + 1;
                    index = i2;
                }
                i2++;
            }

            //Add code to that above loop that tells a user if they put in the text that isn't in the list.
            if (standing == 0)
            {
                Console.WriteLine("That is not a valid team name. Enter again:");
            }
            //add code to that above loop that stops it from executing once a match has been found.
            else
            {
                isValid = true;
            }
        }
        Console.WriteLine("Processing... Index is: " + index + ". So...");
        Console.WriteLine("Standing is: " + standing);
        Console.ReadLine();
    }
}


