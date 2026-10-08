using System;

class Quadrant
{
    static void Main()
    {
        Console.Write("Enter x value: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y value: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant I");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant II");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant III");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant IV");
        }
        else
        {
            Console.WriteLine("The point is on an axis");
        }
    }
}