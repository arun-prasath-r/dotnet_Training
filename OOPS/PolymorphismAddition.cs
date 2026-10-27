using System;

class Addition
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Integer Sum: " + (a + b));
    }

    public void Add(string a, string b)
    {
        Console.WriteLine("String Result: " + (a + b));
    }

    public void Add(double a, double b)
    {
        Console.WriteLine("Double Sum: " + (a + b));
    }
}

class Program
{
    static void Main()
    {
        Addition obj = new Addition();

        obj.Add(10, 20);
        obj.Add("Hello ", "World");
        obj.Add(10.5, 20.5);
    }
}