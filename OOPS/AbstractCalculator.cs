using System;

abstract class Calculator
{
    public abstract void Add(int a, int b);

    public abstract void Sub(int a, int b);

    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    public void Div(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division: " + ((double)a / b));
        else
            Console.WriteLine("Division by zero is not possible");
    }
}

class Operation : Calculator
{
    public override void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public override void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }
}

class AbstractCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Operation obj = new Operation();

        obj.Add(a, b);
        obj.Sub(a, b);
        obj.Mul(a, b);
        obj.Div(a, b);
    }
}