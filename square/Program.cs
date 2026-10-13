
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (char ch = 'a'; ch < 'a' + i; ch++)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
