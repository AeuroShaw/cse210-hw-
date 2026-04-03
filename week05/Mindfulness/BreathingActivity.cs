using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by guiding your breathing slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);

            time += 8;
        }

        EndMessage();
        Console.ReadKey();
    }
}