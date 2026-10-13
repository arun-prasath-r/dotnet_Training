
using System;

class ReverseOddNum
{
    static void Main()
    {
        for (int i = 7; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
