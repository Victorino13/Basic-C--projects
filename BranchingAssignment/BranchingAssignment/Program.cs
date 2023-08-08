using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This block of code prints the welcome message for Package express.
            Console.WriteLine("\"Welcome to Package Express. Please follow the instructions below\"");
            // This block of code ask the customer to enter weight and determines if allowed weight is met.
            Console.WriteLine("Please enter package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
                return;
            }
            // This block of code ask the customer to enter Width, Length, Height of the package and determines if allowed dimension is met.
            Console.WriteLine("Please enter package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package lenght");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            int Dimension = (Convert.ToInt32(packageWidth + packageHeight + packageLength));
            if (Dimension > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package express. Have a good day!");
                Console.ReadLine();
                return;
            }
            // This block of code computes and displays the qoute based on the customer's entered package information
            int totalDimension = (Convert.ToInt32(packageWidth * packageLength * packageLength));
            int dimensionWeight = (totalDimension * packageWeight);
            int qoute = (dimensionWeight / totalDimension);
            Console.WriteLine("Your estimated total for shipping this package is: $" + qoute);

            Console.ReadLine();
        }
    }
}
