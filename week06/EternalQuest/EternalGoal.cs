using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞]";

    public override string GetSaveString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{_points}";
    }
}