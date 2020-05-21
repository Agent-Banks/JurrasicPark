using System;
using System.Collections.Generic;
using System.Linq;

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
                WhenAcquired = DateTime.Now,
                Weight = "12.5 tons",
                EnclouserNumber = 10,
            };

            var triceratops = new Dinosaur
            {
                Name = "Triceratops",
                DietType = "Herbivore",
                WhenAcquired = DateTime.Now,
                Weight = "10 tons",
                EnclouserNumber = 2,
            };

            var velociraptor = new Dinosaur
            {
                Name = "Velociraptor",
                DietType = "Carnivore",
                WhenAcquired = DateTime.Now,
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

                // display the number of carnivores and herbivores
                // there are 3 carnivores and 2 herbivores
                // get the number of times carnivore is shown
                // get the number of times herbivores is shown

                if (option == "S")
                {
                    var numberOfHerbivores = listOfDinosaurs.Count(dinosaur => dinosaur.DietType == "Herbivore");
                    var numberOfCarnivores = listOfDinosaurs.Count(dinosaur => dinosaur.DietType == "Carnivore");
                    Console.WriteLine($"There are {numberOfHerbivores} Herbivores and {numberOfCarnivores} Carnivores");

                }

                if (option == "T")
                {
                    var nameOfDinosaurToFind = PromptForString("Name of Dinosaur being moved to another enclouser");

                    var foundDinosaur = listOfDinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaurToFind);

                    if (foundDinosaur == null)
                    {
                        Console.WriteLine($"Sorry, there is no Dinosaur named {nameOfDinosaurToFind}");
                    }
                    else
                    {
                        var foundDinosaurDescription = foundDinosaur.Description();
                        Console.WriteLine(foundDinosaurDescription);

                        var newDinosaurEnclouser = PromptForInteger("New Enclosure Number: ");

                        foundDinosaur.EnclouserNumber = newDinosaurEnclouser;
                    }
                }


                if (option == "Q")
                {
                    userWantsToQuit = true;
                }

                if (option == "A")
                {
                    var newName = PromptForString("Name: ");
                    var newDietType = PromptForString("DietType: ");
                    var newWhenAcquired = DateTime.Now;
                    var newWeight = PromptForString("Weight: ");
                    var newEnclouserNumber = PromptForInteger("EnclosureNumber: ");

                    var newDinosaur = new Dinosaur
                    {
                        Name = newName,
                        DietType = newDietType,
                        WhenAcquired = newWhenAcquired,
                        Weight = newWeight,
                        EnclouserNumber = newEnclouserNumber,
                    };

                    listOfDinosaurs.Add(newDinosaur);

                }

                if (option == "V")
                {
                    foreach (var dinosaur in listOfDinosaurs)
                    {
                        var dateAcquired = listOfDinosaurs.OrderBy(dinosaur => dinosaur.WhenAcquired);
                        var description = dinosaur.Description();

                        Console.WriteLine(description);
                    }
                }

                if (option == "R")
                {
                    var nameOfDinosaurToFind = PromptForString("Name of Dinosaur being removed: ");

                    var foundDinosaur = listOfDinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaurToFind);

                    if (foundDinosaur == null)
                    {
                        Console.WriteLine($"Sorry, there is no Dinosaur named {nameOfDinosaurToFind}");

                    }

                    else
                    {
                        var foundDinosaurDescription = foundDinosaur.Description();
                        Console.WriteLine(foundDinosaurDescription);

                        var shouldWeDelete = PromptForString("Are you sure you want to delete this dinosaur from the database? (Y/N) ");

                        if (shouldWeDelete == "Y")
                        {
                            listOfDinosaurs.Remove(foundDinosaur);
                        }
                    }
                }


            }
        }
    }
}
