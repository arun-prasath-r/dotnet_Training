
using System;

class  OddNumTri
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int space = 1; space <= 5 - i; space++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write(9 - 2 * j);
            }

            Console.WriteLine();
        }
    }
}
