public class CheckListGoal : Goal
{
    // Attributes
    private int completionPoints;
    private int requiredCount;
    private int currentCount;

    //Constructor
    public CheckListGoal(string name, string description, int points, int completionPoints, int requiredCount) : base(name, description, points)
    {
        this.completionPoints = completionPoints;
        this.requiredCount = requiredCount;
        this.currentCount = 0;
    }
    

    //Overrides methods
    public override int RecordEvent()
    {
        base.RecordEvent(); //Calls base class implementation if needed
        //Implementations unique to ChecklistGoal
        currentCount++;
        return completionPoints;
    }

    public override bool IsComplete()
    {
        base.IsComplete(); //Calls base class implementation if needed
        //Implementations unique to ChecklistGoal
        return currentCount >= requiredCount;
    }












}