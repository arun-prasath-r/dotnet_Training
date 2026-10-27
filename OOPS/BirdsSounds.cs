using System;

class Birds
{
    public string name;

    public Birds(string birdName)
    {
        this.name = birdName;
    }

    public void make_sound()
    {
        Console.WriteLine(name + " makes a sound");
    }
}

class Parrot : Birds
{
    public Parrot() : base("Parrot")
    {
    }

    public new void make_sound()
    {
        Console.WriteLine(name + " says Squawk!");
    }
}

class Sparrow : Birds
{
    public Sparrow() : base("Sparrow")
    {
    }

    public new void make_sound()
    {
        Console.WriteLine(name + " says Chirp Chirp!");
    }
}

class BirdProgram
{
    static void Main()
    {
        Parrot p = new Parrot();
        Sparrow s = new Sparrow();

        p.make_sound();
        s.make_sound();
    }
}