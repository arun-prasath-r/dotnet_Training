
using System;

class DecrementTriangle
{
    static void Main()
    {
        int num = 10;

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 4; j >= i; j--)
            {
                Console.Write(num + " ");
                num--;
            }

            Console.WriteLine();
        }
    }
}
