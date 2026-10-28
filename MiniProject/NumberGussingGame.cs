using System;

class NumberGuessingGame
{
    public int number;
    public int attempts;
    public int score;

    public NumberGuessingGame()
    {
        Random r = new Random();
        number = r.Next(1, 101);
        attempts = 0;
        score = 0;
    }

    public void Play()
    {
        int guess;

        while (attempts < 5)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == number)
            {
                Console.WriteLine("Correct guess!");
                score = (6 - attempts) * 10;
                break;
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low!");
            }
        }

        if (score == 0)
        {
            Console.WriteLine("You lost! The number was " + number);
        }

        Console.WriteLine("Attempts: " + attempts);
        Console.WriteLine("Score: " + score);
    }
}

class NumberGuessingGameApp
{
    static void Main()
    {
        string choice;

        do
        {
            NumberGuessingGame obj = new NumberGuessingGame();
            obj.Play();

            Console.Write("Play again? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}