using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone.",
        "Think of a time when you showed courage."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful to you?",
        "What did you learn from it?",
        "How did you feel afterwards?",
        "What made this experience special?"
    };

    public ReflectionActivity() : base(
        "Reflection",
        "Reflect on times in your life when you showed strength.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        ShowSpinner(5);

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("\n" + _questions[rand.Next(_questions.Count)]);
            ShowSpinner(5);
            time += 5;
        }

        EndMessage();
        Console.ReadKey();
    }
}