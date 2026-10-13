
using System;

class NumRep
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (j <= i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(j);
                }
            }

            Console.WriteLine();
        }
    }
}
