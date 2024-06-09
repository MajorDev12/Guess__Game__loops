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
            Random randomGenerator = new Random();
            int roll = 0; // Initialize roll to 0 or any number outside the range 1-9
            int attempts = 0; // Initialize the attempts counter

            Console.WriteLine("Press enter to roll the dice");

            while (roll != 7)
            {
                Console.ReadKey();

                roll = randomGenerator.Next(1, 10);  // Generates a random number between 1 and 9.
                Console.WriteLine($"Roll result: {roll}. Try again:");
                attempts++;
            }

            Console.WriteLine($"You rolled a 7 after {attempts} attempts!");


        }
    }
}
