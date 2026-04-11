using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score = 0;

    private int _streak = 0;

    private DateTime _lastEntry = DateTime.MinValue;

    public void DisplayScore()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        DisplayLevel();
    }

    private void DisplayLevel()
    {
        int level = _score / 1000 + 1;

        Console.WriteLine($"Level: {level}");

        if (level >= 10)
            Console.WriteLine("🏆 Title: Eternal Champion");
        else if (level >= 5)
            Console.WriteLine("⚔️ Title: Disciple Warrior");
        else
            Console.WriteLine("🌱 Title: Beginner Seeker");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];

            Console.WriteLine($"{i+1}. {g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();

        _score += earned;

        Console.WriteLine($"You earned {earned} points!");

        UpdateStreak();

        CheckBadges();
    }

    private void UpdateStreak()
    {
        DateTime today = DateTime.Today;

        if (_lastEntry == today.AddDays(-1))
            _streak++;
        else if (_lastEntry != today)
            _streak = 1;

        _lastEntry = today;

        Console.WriteLine($"🔥 Current Streak: {_streak} days");
    }

    private void CheckBadges()
    {
        if (_score >= 500 && _score < 600)
            Console.WriteLine("🎉 Badge Unlocked: First Steps!");

        if (_score >= 2000 && _score < 2100)
            Console.WriteLine("🔥 Badge Unlocked: Goal Crusher!");

        if (_score >= 5000 && _score < 5100)
            Console.WriteLine("👑 Badge Unlocked: Legendary Achiever!");
    }

    public void SaveGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            sw.WriteLine(_streak);

            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        _streak = int.Parse(lines[1]);

        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));

            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
        }

        Console.WriteLine("Goals loaded.");
    }
}