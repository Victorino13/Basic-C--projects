using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of integers.
        List<int> intList = new List<int>() { 23, 34, 76, 231, 9812, 65, 42, 10009, 982, 34321 };
        //Ask the user to enter a number that will be divided to list of integers by the entered number
        bool numValid = false;
        while (!numValid)
        {
            //Using a try/catch block to give error message
            try
            {
                Console.WriteLine("\nEnter a number to divide the above list by: ");
                float numDivide = float.Parse(Console.ReadLine());
                //If statement to check if the user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0");
                }
                //Dividing each number in the list by entered number.
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }

            //Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        //Message to let the user know the program has exited the try/catch block
        Console.WriteLine("The program has exited the try and catch block.");
        Console.ReadLine();
    }
}

