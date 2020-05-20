using System;

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



        }
    }
}
