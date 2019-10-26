using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first and last name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, Please enter your favorite number");
            Console.ReadLine();
            Console.WriteLine("Thank you");

            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
