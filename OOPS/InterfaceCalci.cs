using System;

interface IA1
{
    public void Add(int a, int b);
    public void Sub(int a, int b);
}

interface IA2
{
    public void Mul(int a, int b);
    public void Div(int a, int b);
}

class Operations : IA1, IA2
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

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

class InterfaceCalci
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Operations obj = new Operations();

        obj.Add(a, b);
        obj.Sub(a, b);
        obj.Mul(a, b); 
        obj.Div(a, b);
    }
}