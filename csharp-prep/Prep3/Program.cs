using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {   
        string response = "yes";

        do
        {
            
        string found = "no";
        int count = 0;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        while (found == "no")
        {
            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine($"You guessed it in {count} tries!");
                found = "yes";
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }
            count += 1;
        }
        } while (response == "yes");
    }
}