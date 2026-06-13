// Represents a goal that is never completed.
// Users can earn points every time they record progress.
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Awards points every time the goal is recorded.
    public override int RecordEvent()
    {
        return _points;
    }

    // Eternal goals are never complete.
    public override bool IsComplete()
    {
        return false;
    }

    // Creates a formatted display string.
    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_description})";
    }

    // Creates a string used for saving the goal.
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}