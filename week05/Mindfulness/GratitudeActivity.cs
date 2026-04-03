using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity() : base(
        "Gratitude",
        "Think about things you are grateful for today.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\nThink about something you are grateful for.");
        ShowSpinner(5);

        Console.WriteLine("\nNow think about why you are grateful for it.");
        ShowSpinner(5);

        Console.WriteLine("\nHow does it make your life better?");
        ShowSpinner(5);

        EndMessage();
        Console.ReadKey();
    }
}