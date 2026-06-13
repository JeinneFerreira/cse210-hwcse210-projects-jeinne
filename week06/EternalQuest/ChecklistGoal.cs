// Represents a goal that must be completed
// a specific number of times before finishing.
public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _targetCount;
    private int _amountCompleted;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Records progress toward the goal.
    // Awards a bonus when the target is reached.
    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _targetCount)
        {
            return _points + _bonus;
        }

        return _points;
    }

    // Returns whether the checklist goal is complete.
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }

    // Creates a formatted display string.
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {_name} ({_description}) -- Completed {_amountCompleted}/{_targetCount}";
    }

    // Creates a string used for saving the goal.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_targetCount},{_amountCompleted}";
    }
}

//