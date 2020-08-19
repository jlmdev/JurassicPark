using System;

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

                // View
                // Test Dinosaur
                var testDino = new Dinosaur();
                testDino.Name = "George";
                testDino.DietType = "herbivore";
                testDino.Weight = 2000;
                testDino.EnclosureNumber = 4;

                // Call Description Method
                var classDescription = testDino.Description();
                Console.WriteLine(classDescription);


                // Close Program
                closeProgram = Console.ReadLine();


            }


            // Say Goodbye
            Console.WriteLine("Goodbye.");

        }
    }
}
