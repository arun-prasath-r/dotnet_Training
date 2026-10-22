using System;
public class KthSmallest
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
        int distinct = 0;
        for (int i = 0; i < n; i++) if (i == 0 || num_array[i] != num_array[i - 1]) distinct++;
        Console.Write("\nEnter k (1 to " + distinct + ") : ");
        int k = Convert.ToInt32(Console.ReadLine());
        while (k < 1 || k > distinct)
        {
            Console.Write("Invalid k. Enter k (1 to " + distinct + ") : ");
            k = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
            if (i == 0 || num_array[i] != num_array[i - 1])
                if (--k == 0) { Console.WriteLine("The kth-smallest distinct element is " + num_array[i]); break; }
    }
}
