using System;

class Greeting
{
    static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
            name = "friend";

        Console.WriteLine($"Hello, {name}! Welcome to C#.");
    }
}
