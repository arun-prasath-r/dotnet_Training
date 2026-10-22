using System;
public class ArraySum
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num_array = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the element " + (i + 1) + " : ");
            num_array[i] = Convert.ToInt32(Console.ReadLine());
            sum += num_array[i];
        }
        Console.Write("The elements in the array : ");
        foreach (int number in num_array) Console.Write(number + " ");
        Console.WriteLine("\nThe sum of the array elements is " + sum);
    }
}
