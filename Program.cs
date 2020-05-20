using System;
using System.Collections.Generic;

namespace JurrasicPark
{
    class Program
    {

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var inputFromUser = Console.ReadLine();

            return inputFromUser;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int inputFromUser;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out inputFromUser);

            if (isThisGoodInput)
            {
                return inputFromUser;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            var tyrannosaurus = new Dinosaur
            {
                Name = "Tyrannosaurus",
                DietType = "Carnivore",
                WhenAcquired = "",
                Weight = "12.5 tons",
                EnclouserNumber = 10,
            };

            var triceratops = new Dinosaur
            {
                Name = "Triceratops",
                DietType = "Herbivore",
                WhenAcquired = "",
                Weight = "10 tons",
                EnclouserNumber = 2,
            };

            var velociraptor = new Dinosaur
            {
                Name = "Velociraptor",
                DietType = "Carnivore",
                WhenAcquired = "",
                Weight = "30 pounds",
                EnclouserNumber = 10,
            };

            var listOfDinosaurs = new List<Dinosaur>();

            listOfDinosaurs.Add(tyrannosaurus);
            listOfDinosaurs.Add(triceratops);
            listOfDinosaurs.Add(velociraptor);

            Console.WriteLine();
            Console.WriteLine($"Welcome to our Dinosaur database, we currently have {listOfDinosaurs.Count} Dinosaurs in our park.");
            Console.WriteLine();

            var userWantsToQuit = false;

            while (userWantsToQuit == false)
            {
                // Menu is shown to user and they must pick an option
                Console.WriteLine("Please choose an option");
                Console.WriteLine("(V)iew all the Dinosaurs in the park");
                Console.WriteLine("(A)dd a Dinosaur to the database");
                Console.WriteLine("(R)emove a Dinosaur for the database");
                Console.WriteLine("(T)ransfer a Dinosaur to a new Enclosure");
                Console.WriteLine("(S)ummary of all the Carnivores and Herbivores in the park");
                Console.WriteLine("(Q)uit the application");
                Console.WriteLine();

                var option = PromptForString("Option: ");

                if (option == "Q")
                {
                    userWantsToQuit = true;
                }

            }
        }
    }
}
