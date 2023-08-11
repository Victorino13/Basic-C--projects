using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //Part 1
        //Dimensional Array of strings - Split sentences.
        string[] wordstart =
         {
            "Hello and Welcome to ",
            "My name is ",
            "I will make sure that you will be "
        };
        string[] wordend =
        {
            " Show.",
            ".",
            ". Have fun!"
        };
        List<string> responses = new List<string>();
        //This code ask the user to enter some text.
        Console.WriteLine("Please enter a memorable place for you");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter a random name");
        responses.Add(Console.ReadLine());
        Console.WriteLine("Please enter an reaction feeling");
        responses.Add(Console.ReadLine());
        //A loop that goes through each string in the Array, adding the user's entered text to string.
        for (int i = 0; i < wordstart.Length; i++)
        {
            wordstart[i] += responses[i];
            Console.WriteLine(wordstart[i] + wordend[i]);
        }
        Console.ReadLine();

        //This code creates a second a loop that prints off each string in the Array on a separate line.
        Console.WriteLine("The strings we used are:");
        for (int i = 0; i < wordstart.Length; i++) 
        {
            Console.WriteLine(wordstart[i] + wordend[i]);
        }
        Console.ReadLine();
    }
}

       
