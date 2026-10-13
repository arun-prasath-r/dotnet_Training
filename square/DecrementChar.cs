
using System;

class DecrementChar
{
    static void Main()
    {
        char ch = 'z';

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 4; j >= i; j--)
            {
                Console.Write(ch + " ");
                ch--;
            }

            Console.WriteLine();
        }
    }
}
