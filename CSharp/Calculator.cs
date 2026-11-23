using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case "/":
                if (b == 0)
                    Console.WriteLine("Error: cannot divide by zero.");
                else
                    Console.WriteLine($"{a} / {b} = {a / b}");
                break;
            default:
                Console.WriteLine("Error: invalid operator.");
                break;
        }
    }
}
