using System;
using System.Collections.Generic;

// Creativity: This program exceeds the requirements by allowing the user
// to randomly receive one of several scriptures instead of always using one.
// This gives more variety when practicing scripture memorization.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
        ));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
        ));

        scriptures.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God"
        ));

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden. Program finished.");
    }
}