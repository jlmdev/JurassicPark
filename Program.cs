using System;

namespace JurassicPark
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Welcome to Jurassic Park.\n\n");

            // initialize variables
            var closeProgram = "n";

            // While loop to continue program
            while (closeProgram != "q")
            {
                // Show Menu
                Console.WriteLine("Menu:");
                Console.WriteLine("View");
                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("Transfer");
                Console.WriteLine("Summary");
                Console.WriteLine("Quit");


                // Close Program
                closeProgram = Console.ReadLine();


            }


            // Say Goodbye
            Console.WriteLine("Goodbye.");

        }
    }
}
