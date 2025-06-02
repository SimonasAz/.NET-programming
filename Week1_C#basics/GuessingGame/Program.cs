// See https://aka.ms/new-console-template for more information
using System;

class Program{
    static void Main()
    {
        string playAgain;
        do
        {
            PlayGame();

            Console.WriteLine("Do you want to play again? (y/n): ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "y");
        Console.WriteLine("Thanks for playing");
    }

    static void PlayGame(){
        Console.WriteLine("Choose a number between 1-100");

        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        int input = 0;
        int guesses = 0;

        while (input != number)
        {
            Console.WriteLine("Try another number: ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < number) Console.WriteLine("Too low");
            else if (input > number) Console.WriteLine("Too high");
            else Console.WriteLine("Congrats you've guessed the number");
            guesses++;

        }
        Console.WriteLine($"Congrats it took you {guesses} tries");

    }
}


