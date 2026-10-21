
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        bool found = false;

        Console.WriteLine("ARMSTRONG NUMBER CHECKER");
        Console.WriteLine("------------------------");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nArmstrong numbers in the array:");

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            int temp = num;
            int sum = 0;
            int digits = num.ToString().Length;

            if (num < 0)
                continue;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine($"Armstrong number: {num}");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No Armstrong numbers were found.");
    }
}
