using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case 4:
                Console.WriteLine("Result: " + (num1 / num2));
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}