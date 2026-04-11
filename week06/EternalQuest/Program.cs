/*
EXCEEDING REQUIREMENTS

This Eternal Quest program exceeds the assignment requirements by
implementing additional gamification systems:

1. LEVEL SYSTEM
Users gain levels based on total points earned.

2. ACHIEVEMENT BADGES
Players unlock badges at major score milestones.

3. DAILY STREAK TRACKER
The program tracks consecutive days that goals are recorded.

4. GOAL FACTORY CLASS
A GoalFactory class was added to improve abstraction and clean
goal creation logic.

These improvements make the program more engaging and better
organized while demonstrating strong object-oriented design.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            manager.DisplayScore();

            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1 Simple Goal");
                Console.WriteLine("2 Eternal Goal");
                Console.WriteLine("3 Checklist Goal");

                Console.Write("Type: ");
                string type = Console.ReadLine();

                Goal goal = GoalFactory.CreateGoal(type);

                if (goal != null)
                    manager.AddGoal(goal);
            }

            else if (choice == "2")
                manager.ListGoals();

            else if (choice == "3")
                manager.RecordEvent();

            else if (choice == "4")
                manager.SaveGoals();

            else if (choice == "5")
                manager.LoadGoals();

            else if (choice == "6")
                break;
        }
    }
}

