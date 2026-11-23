using System;

class EvenOdd
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine($"{number} is even.");
        else
            Console.WriteLine($"{number} is odd.");

        Console.WriteLine("Even numbers from 1 to 50:");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
