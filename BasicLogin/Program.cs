using System;
class Login
{
    static void Main()
    {
        string standardUsername = "admin@1234";
        string standardPassword = "12345";

        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;

        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;

        if (username == standardUsername)
        {
            if (password == standardPassword)
            {
                Console.WriteLine("Login successful!");
            }
        }
        if (username == standardUsername)
        {
            if (password != standardPassword)
            {
                Console.WriteLine("Username or Password incoorrect!");
            }
        }
        else
        {
            Console.WriteLine("Username or Password incoorrect!");
        }
    }
}