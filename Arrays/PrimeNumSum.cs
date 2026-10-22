
using System;

class PrimeNumSum
{
    static void Main()
    {
        int[] arr = new int[5];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            bool isPrime = arr[i] >= 2;

            for (int j = 2; j < arr[i]; j++)
            {
                if (arr[i] % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                count++;
            }
        }
        Console.WriteLine($"\nTotal prime number: {count}");
    }
}
