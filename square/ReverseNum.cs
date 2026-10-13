
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int space = 1; space <= 4 - i; space++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + 2 + " ");
            }

            Console.WriteLine();
        }
    }
}
