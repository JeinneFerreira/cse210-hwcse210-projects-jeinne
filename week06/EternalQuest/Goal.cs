// Abstract base class for all goal types.
// Contains the common attributes and behaviors shared by every goal.
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor used by all derived goal classes.
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Returns the goal name.
    public string GetName()
    {
        return _name;
    }

    // Records an event and returns the points earned.
    public abstract int RecordEvent();

    // Determines whether the goal is complete.
    public abstract bool IsComplete();

    // Returns a formatted string for displaying the goal.
    public abstract string GetDetailsString();

    // Returns a string representation for saving to a file.
    public abstract string GetStringRepresentation();
}


//