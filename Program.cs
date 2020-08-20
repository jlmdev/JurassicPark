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
            var dinoDescription = ($"{Name} is a {Weight} pound {DietType} located in enclosure {EnclosureNumber} that arrived {WhenAcquired}");
            return dinoDescription;
        }
    }
    class Program
    {
        static Dinosaur PromptAndFindDino(List<Dinosaur> DinoSearchList)
        {
            Console.Write("Name: ");
            var nameOfDinoToSearchFor = Console.ReadLine();

            // Find dino from the list that was input
            var foundDino = DinoSearchList.FirstOrDefault(dino => dino.Name == nameOfDinoToSearchFor);

            return foundDino;
        }
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

                // Menu Handling
                var menu = Console.ReadLine();
                switch (menu)
                {
                    case "v":
                        if (dinoList.Any() == true)
                        {
                            var orderedList = dinoList.OrderBy(dino => dino.WhenAcquired);
                            foreach (var dino in orderedList)
                            {
                                Console.WriteLine(dino.Description());
                            }
                        }
                        else
                        {
                            Console.WriteLine("The park is empty.");
                        }
                        break;
                    case "a":
                        // Add Functionality
                        // Prompt for details

                        // Prompt for Name
                        Console.Write("Name: ");
                        var name = Console.ReadLine();

                        // Prompt for DietType
                        Console.Write("Diet Type: ");
                        var diet = Console.ReadLine();

                        // Prompt for Weight
                        Console.Write("Weight: ");
                        var weightString = Console.ReadLine();
                        var weight = int.Parse(weightString);

                        // Prompt for EnclosureNumber
                        Console.Write("Enclosure Number: ");
                        var enclosureNumberString = Console.ReadLine();
                        var enclosureNumber = int.Parse(enclosureNumberString);

                        // Make a Dinosaur
                        var newDino = new Dinosaur()
                        {
                            Name = name,
                            DietType = diet,
                            Weight = weight,
                            EnclosureNumber = enclosureNumber,
                        };

                        // Add Dinosaur to the List
                        dinoList.Add(newDino);
                        break;
                    case "r":
                        // Remove Functionality
                        var foundDino = PromptAndFindDino(dinoList);
                        // Check if Dinosaur name matches any in the list
                        if (foundDino != null)
                        {
                            // Show found Dinosaur
                            Console.WriteLine(foundDino.Description());

                            // Confirm choice
                            Console.Write("Are you sure you want to remove? (y)es or (n)o ");
                            var confirm = Console.ReadLine();

                            if (confirm == "y")
                            {
                                dinoList.Remove(foundDino);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no dinosaur by that name");
                        }

                        break;
                    case "t":
                        // Transfer Functionality
                        var transferDino = PromptAndFindDino(dinoList);
                        // Check if Dinosaur name matches any in the list
                        if (transferDino != null)
                        {
                            // Show found Dinosaur
                            Console.WriteLine(transferDino.Description());

                            // Confirm choice
                            Console.Write("Are you sure you want to move this dinosaur? (y)es or (n)o ");
                            var confirm = Console.ReadLine();

                            if (confirm == "y")
                            {
                                Console.Write("New enclosure: ");
                                var newEnclosure = int.Parse(Console.ReadLine());

                                transferDino.EnclosureNumber = newEnclosure;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no dinosaur by that name.");
                        }
                        break;
                    case "s":
                        // Summary Functionality
                        // Get count of herbivores and carnivores
                        var herbivores = dinoList.Count(dino => dino.DietType == "herbivore");
                        var carnivores = dinoList.Count(dino => dino.DietType == "carnivore");

                        // Output counts to screen
                        Console.WriteLine($"Herbivores: {herbivores}");
                        Console.WriteLine($"Carnivores: {carnivores}");

                        break;
                    case "q":
                        closeProgram = "q";
                        break;
                    default:
                        break;
                }


            }

            // Say Goodbye
            Console.WriteLine("Goodbye.");

        }
    }
}
