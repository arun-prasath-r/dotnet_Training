
using System;

class PrimeNumArray
{
    static void Main()
    {
        int[] arr = new int[5];
        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nPrime numbers in the array:");

        for (int i = 0; i < arr.Length; i++)
        {
            bool isPrime = true;

            if (arr[i] < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"Prime number: {arr[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No prime numbers were found in the array.");
        }
    }
}
