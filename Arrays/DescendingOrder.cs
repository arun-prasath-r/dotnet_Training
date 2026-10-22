using System;
public class DescendingOrder
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num_array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the element " + (i + 1) + " : ");
            num_array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The elements in the array : ");
        foreach (int number in num_array) Console.Write(number + " ");
        Array.Sort(num_array);
        Array.Reverse(num_array);
        Console.Write("\nThe elements in descending order : ");
        foreach (int number in num_array) Console.Write(number + " ");
    }
}
