using System;

namespace SelectionStatementsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 9;
            Console.WriteLine("Guess favorite number below 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {

                Console.WriteLine("Not Accurate!!");
            }


            else if (userGuess > favoriteNumber)
            {

                Console.WriteLine("Too High!!");
            }

            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You're Right!!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
