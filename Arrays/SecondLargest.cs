using System;
public class SecondLargest
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
        int largest = num_array[n - 1];
        bool found = false;
        for (int i = n - 2; i >= 0; i--)
        {
            if (num_array[i] != largest)
            {
                Console.WriteLine("\nThe second-largest distinct element is " + num_array[i]);
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine("\nThere is no second-largest distinct element.");
    }
}
