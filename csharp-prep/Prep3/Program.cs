using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(1,101);
        int guess;
        int num_guesses = 0;
        bool play_again;

        do {
            do {
                Console.Write("What is your guess? ");
                guess = Convert.ToInt16(Console.ReadLine());
                if (number > guess) {
                    Console.WriteLine("Higher");
                } else if (number < guess) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("You guessed it!");
                }
                num_guesses += 1;
            } while (number != guess);

            Console.WriteLine($"You made {num_guesses} guesses.");
            Console.WriteLine("Would you like to play again?");
            play_again = Console.ReadLine() == "yes";
        } while (play_again);
    }
}