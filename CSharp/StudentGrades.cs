using System;

class StudentGrades
{
    static void Main()
    {
        int[] scores = new int[5];

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score for student {i + 1} (0-100): ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int highest = scores[0];
        int lowest = scores[0];

        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
            if (scores[i] > highest) highest = scores[i];
            if (scores[i] < lowest) lowest = scores[i];
        }

        double average = (double)sum / scores.Length;

        Console.WriteLine("\n--- Results ---");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: {scores[i]} -> {GetGrade(scores[i])}");
        }

        Console.WriteLine($"\nAverage: {average:F2}");
        Console.WriteLine($"Highest: {highest}");
        Console.WriteLine($"Lowest:  {lowest}");
    }

    static string GetGrade(int score)
    {
        if (score >= 90) return "A";
        if (score >= 80) return "B";
        if (score >= 70) return "C";
        if (score >= 60) return "D";
        return "F";
    }
}
