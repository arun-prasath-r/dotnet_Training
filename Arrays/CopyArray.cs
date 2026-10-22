using System;
public class CopyArray
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the size of the array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] num_array = new int[n];
        int[] copy_array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the element " + (i + 1) + " : ");
            num_array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The elements in the array : ");
        foreach (int number in num_array) Console.Write(number + " ");
        for (int i = 0; i < n; i++) copy_array[i] = num_array[i];
        bool same = num_array.Length == copy_array.Length;
        for (int i = 0; i < n; i++) if (num_array[i] != copy_array[i]) same = false;
        Console.WriteLine("\nBoth arrays have the same length: " + (num_array.Length == copy_array.Length));
        Console.WriteLine("Both arrays contain identical elements: " + same);
    }
}
