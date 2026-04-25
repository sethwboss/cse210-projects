using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);


        int guessnum = 101;
        while (guessnum != number)
        {
            
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            guessnum = int.Parse(guess);

            if (number > guessnum) {
                Console.WriteLine("Higher");
            }
            else if (number < guessnum) {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}