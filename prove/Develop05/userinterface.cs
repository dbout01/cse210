using System;
using System.Collections.Generic;

public class UserInterface
{
    //Methods
    public void DisplayScore(int score)
    {
        Console.WriteLine($"Your current score: {score}");
    }

    public void DisplayGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals: ");
        foreach (var goal in goals)
        {
            Console.WriteLine($"- {goal.GetName()} ({goal.GetDescription()}) [{(goal.IsCompleted() ? "X" : " ")}]");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"  Completed {checklistGoal.GetCurrentCount()}/{checklistGoal.GetRequiredCount()} times");
            }
        }
    }
    
    public string GetUserInput()
    {
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }
}