using System;

class SecretCodeBreaker
{
    public string secretCode;
    public int attempts;
    public int score;

    public SecretCodeBreaker()
    {
        Random r = new Random();
        secretCode = r.Next(0, 10000).ToString("D4");
        attempts = 0;
        score = 0;
    }

    public void Play()
    {
        string guess;

        while (attempts < 10)
        {
            Console.Write("Enter 4-digit code: ");
            guess = Console.ReadLine();

            if (guess.Length != 4 || !int.TryParse(guess, out _))
            {
                Console.WriteLine("Enter exactly 4 digits!");
                continue;
            }

            attempts++;
            int correct = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretCode[i])
                    correct++;
            }

            if (guess == secretCode)
            {
                Console.WriteLine("Congratulations! Code cracked!");
                score = (11 - attempts) * 10;
                break;
            }
            else
            {
                Console.WriteLine("Correct digits in correct positions: " + correct);
                Console.WriteLine("Attempts remaining: " + (10 - attempts));
            }
        }

        if (score == 0)
            Console.WriteLine("Game over! Secret code was: " + secretCode);

        Console.WriteLine("Attempts used: " + attempts);
        Console.WriteLine("Your score: " + score);
    }
}

class Program
{
    static void Main()
    {
        string choice;

        do
        {
            SecretCodeBreaker obj = new SecretCodeBreaker();
            obj.Play();

            Console.Write("Try a new code? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}