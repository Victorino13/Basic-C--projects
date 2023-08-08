using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Array of strings
        string[] brandArray = { " Gucci", " LV", " Gildan", " Nike", " Adidas", " Puma", };
        // Ask the user to enter number to display corresponding color in the array
        Console.WriteLine("Select a number from 0 to 5");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        bool validString = false;

        //Displays the matched number and string when entered number is in the given range
        while (!validString)
        {
            try
            {
                Console.WriteLine("Your favorite brand is" + brandArray[stringSelect]);
                validString = true;
            }
            // Displays a message when entered number is not on the given range
            catch
            {
                Console.WriteLine("The number you entered is invalid, Please select a number from 0 to 5. ");
                stringSelect = Convert.ToInt32(Console.ReadLine());
            }
        }

        //List of Strings
        List<string> foodList = new List<string>()
        {
            "Japanese", "Chinese", "Filipino", "American", "Mexican", "Persian"
        };

        // Ask user to enter a number to correspond with the type of food listed.
        Console.WriteLine("\nPlease enter a number between 0 and 5:");
        int numSelect = Convert.ToInt32(Console.ReadLine());
        bool validList = false;

        // Displays type of food when entered number is in the given range
        while (!validList)
        {
            try
            {
                Console.WriteLine("Your choice of food is: " + foodList[numSelect]);
                validList = true;
            }
            // Displays an error message if entered number is not in the given range
            catch
            {
                Console.WriteLine("The number you entered is invalid. Please enter a number from 0 to 5");
                numSelect = Convert.ToInt32(Console.ReadLine());
            }

        }
        Console.ReadLine();
    }
}
