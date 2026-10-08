using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("a. Addition");
        Console.WriteLine("b. Subtraction");
        Console.WriteLine("c. Multiplication");
        Console.WriteLine("d. Division");

        Console.Write("Enter your choice: ");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case 'a':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case 'b':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case 'c':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case 'd':
                Console.WriteLine("Result: " + (num1 / num2));
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}