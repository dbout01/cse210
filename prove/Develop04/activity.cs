using System;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _durationInSeconds;

    public Activity(string activityName, string description, int durationInSeconds)
    {
        _activityName = activityName;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_durationInSeconds} seconds");
        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_activityName}.");
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Duration: {_durationInSeconds} seconds");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}