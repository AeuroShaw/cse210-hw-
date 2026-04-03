using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity (Extra)");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == 4)
            {
                GratitudeActivity activity = new GratitudeActivity();
                activity.Run();
            }
        }
    }
}