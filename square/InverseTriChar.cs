using System;

class InverseTriChar
{
    static void Main()
    {
        int rows = 4;

        for (int i = 1; i <= rows; i++)
        {
            // Print leading spaces
            for (int space = 1; space < i; space++)
            {
                Console.Write(" ");
            }

            char ch = 'A';

            // Print characters
            for (int j = 1; j <= rows - i + 1; j++)
            {
                if (i == 1 || j == 1 || j == rows - i + 1)
                {
                    Console.Write(ch);
                }
                else
                {
                    Console.Write(" ");
                }

                ch++;
            }

            Console.WriteLine();
        }
    }
}