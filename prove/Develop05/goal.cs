public class Goal
{
    //Attributes
    private string name;
    private string description;
    private int points;
    private bool completed;

    //Constructor
    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.completed = false;
    }

    //Methods
    public string GetName() => name;
    public string GetDescription() => description;
    public int GetPoints() => points;
    public bool IsCompleted() => completed;

    public virtual int RecordEvent()
    {
        //base implementation for recording events
        //(will be overriden in derived classes)
        return points;
    }

    public virtual bool IsComplete()
    {
        //base implementation for checking completion
        //(will be overriden in derived classes)
        return completed;
    }




    }