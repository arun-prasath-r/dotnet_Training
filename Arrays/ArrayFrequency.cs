using System;
public class ArrayFrequency
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
        Console.WriteLine("\nElement frequencies :");
        for (int i = 0; i < n; i++)
        {
            bool counted = false;
            for (int j = 0; j < i; j++) if (num_array[i] == num_array[j]) counted = true;
            if (!counted)
            {
                int count = 0;
                for (int j = 0; j < n; j++) if (num_array[i] == num_array[j]) count++;
                Console.WriteLine(num_array[i] + " occurs " + count + " time(s)");
            }
        }
    }
}
