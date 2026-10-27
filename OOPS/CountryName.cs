using System;

class Country
{
    public string name;

    public Country(string countryName)
    {
        name = countryName;
    }

    public void capital()
    {
        Console.WriteLine("Capital of " + name);
    }

    public void language()
    {
        Console.WriteLine("Language of " + name);
    }
}

class India : Country
{
    public India() : base("India")
    {
    }

    public new void capital()
    {
        Console.WriteLine("Capital: New Delhi");
    }

    public new void language()
    {
        Console.WriteLine("Language: Hindi and English");
    }
}

class USA : Country
{
    public USA() : base("USA")
    {
    }

    public new void capital()
    {
        Console.WriteLine("Capital: Washington, D.C.");
    }

    public new void language()
    {
        Console.WriteLine("Language: English");
    }
}

class UK : Country
{
    public UK() : base("UK")
    {
    }

    public new void capital()
    {
        Console.WriteLine("Capital: London");
    }

    public new void language()
    {
        Console.WriteLine("Language: English");
    }
}

class CountryProgram
{
    static void Main()
    {
        India i = new India();
        USA u = new USA();
        UK k = new UK();

        Console.WriteLine(i.name);
        i.capital();
        i.language();

        Console.WriteLine();

        Console.WriteLine(u.name);
        u.capital();
        u.language();

        Console.WriteLine();

        Console.WriteLine(k.name);
        k.capital();
        k.language();
    }
}