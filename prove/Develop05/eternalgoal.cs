public class EternalGoal : Goal
{
    // Attribute
    private int completionPoints;

    //Constructor
    public EternalGoal(string name, string description, int points, int completionPoints) : base(name, description, points)
    {
        this.completionPoints = completionPoints;
    }

    // Overrides Methods
    public override int RecordEvent()
    {
        base.RecordEvent(); // Call base class implementation if needed
        // Additional implementation for recording events specific to EternalGoal
        return completionPoints;
    }

}