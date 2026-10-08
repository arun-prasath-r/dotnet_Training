using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your marks out of 500: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        double percentage = (marks / 500) * 100;
        double fee = 185000;

        Console.WriteLine("Your percentage is: " + percentage + "%");

        if (percentage > 90)
        {
            fee = fee * 50 / 100;

            Console.WriteLine("Congratulations!");
            Console.WriteLine("You got 50% scholarship.");
        }
        else
        {
            Console.WriteLine("You did not qualify for the scholarship.");
        }

        Console.WriteLine("Your final fee is: ₹" + fee);
    }
}