using System;
using System.Collections.Generic;

public class UserInterface
{
    //Methods
    public void DisplayScore (int score)
    {
        Console.WriteLine($"Your current score: {score}");
    }

    public void DisplayGoals(List<Goal> goals)
    {
        Console.WriteLine("Your goals: ");
        foreach (var goal in goals)
        {
            string completionStatus = goal.IsCompleted() ? "[X]" : "[ ]";
            if (goal is CheckListGoal checklistGoal)
            {
                completionStatus += $" Completed {checklistGoal.GetCurrentCount()}/{checklistGoal.GetRequiredCount()} times";
            }
                Console.WriteLine($"{completionStatus} {goal.GetName()}: {goal.GetDescription()}");
        }
    }

    public string GetUserInput()
    {
        Console.Write("Etner your choice: ");
        return Console.ReadLine();
    }

}