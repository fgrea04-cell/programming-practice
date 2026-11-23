using System;

class NumberGuess
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 101); // 1 to 100 inclusive
        int attempts = 0;
        int guess = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        while (guess != secret)
        {
            Console.Write("Your guess: ");
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid whole number.");
                continue;
            }

            attempts++;

            if (guess > secret)
                Console.WriteLine("Too high!");
            else if (guess < secret)
                Console.WriteLine("Too low!");
        }

        Console.WriteLine($"Correct! You got it in {attempts} attempts.");
    }
}
