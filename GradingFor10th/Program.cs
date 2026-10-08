using System;
using System;

class Grade
{
    static void Main()
    {
        double total = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter mark " + i + ": ");
            double mark = Convert.ToDouble(Console.ReadLine());
            total = total + mark;
        }

        double percentage = (total / 500) * 100;

        Console.WriteLine("Total Marks : " + total);
        Console.WriteLine("Percentage  : " + percentage + "%");

        if (percentage > 95)
        {
            Console.WriteLine("Grade: S");
        }
        else if (percentage > 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (percentage > 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (percentage > 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (percentage > 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}