using System;


namespace ConsoleApp1___loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loops
            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("yes");
            }*/



            /*int age = 10;

            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("yes");
            }*/


            //guess game

            //process
            // - welcome the game
            // - give out the rules of the game
            // - readline
            // - check if input equals to targetNumber (while loop)
            // - if no, get input again
            // - if yes, return congrats




            int attempts = 0; // Initialize the attempts counter
            const int targetNumber = 4; // The number to guess

            Console.WriteLine("Welcome to the Guess Number Game!");
            Console.WriteLine("Guess a number between 1 and 9");

            bool isNumberValid = false; // Flag to check if input is a valid number
            int input = 0; // Initialize the input variable

            while (!isNumberValid || input != targetNumber)
            {
                string roll = Console.ReadLine(); // Read user input as a string

                // Try to parse the string input to an integer
                if (int.TryParse(roll, out input))
                {
                    // Check if the input is within the valid range (1-9)
                    if (input < 1 || input > 9)
                    {
                        Console.WriteLine("Please guess a number between 1 and 9.");
                        attempts++;
                        continue; // Prompt the user to guess again
                    }

                    isNumberValid = true; // The input is valid

                    // Check if the input matches the target number
                    if (input != targetNumber)
                    {
                        Console.WriteLine($"Not {input}, Try again.");
                        attempts++; // Increment the attempts counter
                    }
                }
                else
                {
                    // Handle invalid input (not a number)
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.WriteLine($"Congrats! You guessed the number {targetNumber} correctly after {attempts} attempts!");
            Console.ReadKey();
        }
    }
}


