using System;
using System.Collections.Generic;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first and last name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, Please enter your favorite number");

            
            string num1 = Console.ReadLine();

            
            if (Convert.ToInt32(num1) > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (Convert.ToInt32(num1) < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }







                Console.WriteLine("Thank you!");

            Console.WriteLine("Please enter your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"Great! So {name}, your favorite number is {num1} and your favorite animal is a {animal}!");
            

           



            
            

            
            
            
            
                

            
            
       


        

        
            
            
            
            
        

            


            


            
            
            




            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }

    internal class num1
    {
    }
}
}
