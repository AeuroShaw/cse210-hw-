using System;

public static class GoalFactory
{
    public static Goal CreateGoal(string type)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            return new SimpleGoal(name, desc, points);
        }

        if (type == "2")
        {
            return new EternalGoal(name, desc, points);
        }

        if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            return new ChecklistGoal(name, desc, points, target, bonus);
        }

        return null;
    }
}