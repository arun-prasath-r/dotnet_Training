
using System;

class MagicNumSum
{
    static void Main()
    {
        int[] arr = new int[5];
        bool found = false;

        Console.WriteLine("MAGIC NUMBER CHECKER");
        Console.WriteLine("--------------------");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nMagic numbers in the array:");

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];

            if (num <= 0)
                continue;

            while (num > 9)
            {
                int sum = 0;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                num = sum;
            }

            if (num == 1)
            {
                Console.WriteLine($"Magic number: {arr[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No magic numbers were found.");
        }
    }
}
