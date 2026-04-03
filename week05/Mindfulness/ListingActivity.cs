using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are personal strengths you have?",
        "Who have you helped recently?",
        "What are blessings in your life?"
    };

    public ListingActivity() : base(
        "Listing",
        "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nStart listing in:");
        ShowCountdown(5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        EndMessage();
        Console.ReadKey();
    }
}