public class SimpleGoal : Goal
{
    //Attribute
    private int completionPoints;

    //Constructor
    public SimpleGoal(string name, string description, int points, int completionPoints) : base(name,description, points)
    {
        this.completionPoints = completionPoints;
    }

    //Overrides methods
    public override int RecordEvent()
    {
        base.RecordEvent();
        //Calls base class implementation if needed
        //More implementation for recording events specific to SimpleGoal
        return completionPoints;
    }
}