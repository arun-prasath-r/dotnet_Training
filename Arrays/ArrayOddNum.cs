
using System;

class ArrayOddNum
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;

        Console.WriteLine("ODD NUMBER SUM CALCULATOR");
        Console.WriteLine("-------------------------");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                sum += arr[i];
            }
        }

        Console.WriteLine($"\nSum of odd numbers in the array: {sum}");
    }
}
