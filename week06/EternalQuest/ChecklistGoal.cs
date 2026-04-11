using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int count=0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = count;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;

            if (_count == _target)
                return _points + _bonus;

            return _points;
        }

        return 0;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
    {
        string check = IsComplete() ? "X" : " ";
        return $"[{check}] Completed {_count}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{_points}|{_target}|{_bonus}|{_count}";
    }
}