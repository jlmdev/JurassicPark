using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    // Dinosaur Class
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public string Description()
        {
            var dinoDescription = ($"{Name} is a {Weight} pound {DietType} located in {EnclosureNumber} that arrived {WhenAcquired}");
            return dinoDescription;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Greeting
            Console.WriteLine("Welcome to Jurassic Park.\n\n");

            // initializers
            var closeProgram = "n";
            var dinoList = new List<Dinosaur>();

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

                // Test Dinosaur
                var testDino = new Dinosaur();
                testDino.Name = "George";
                testDino.DietType = "herbivore";
                testDino.Weight = 2000;
                testDino.EnclosureNumber = 4;
                dinoList.Add(testDino);

                // Call Description Method
                // var classDescription = testDino.Description();
                // Console.WriteLine(classDescription);
                // View
                if (dinoList.Any() == true)
                {

                    foreach (var dino in dinoList)
                    {
                        Console.WriteLine(dino.Description());
                    }
                }
                else
                {
                    Console.WriteLine("The park is empty.");
                }


                // Close Program
                closeProgram = Console.ReadLine();


            }


            // Say Goodbye
            Console.WriteLine("Goodbye.");

        }
    }
}
