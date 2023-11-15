using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creates an instance of UserInterface
        UserInterface ui  = new UserInterface();

        //Creates a list to store goals
        List<Goal> goals = new List<Goal>();

        //Goals
        Goal simpleGoal = new SimpleGoal("Run a marathon", "Complete a triathalon", 1000, 200);
        Goal eternalGoal = new EternalGoal("Read scriptures", "Read scriptures daily", 100, 50);
        Goal checklistGoal = new ChecklistGoal("Go grocery shopping", "go to a movie", 50, 500, 10);

        //Adds goals to the list
        goals.Add(simpleGoal);
        goals.Add(eternalGoal);
        goals.Add(checklistGoal);

        //Displays beginning goals
        ui.DisplayGoals(goals);
        ui.DisplayScore(CalculateTotalScore(goals));

        //Records events
        RecordEvents(goals);

        //Displays updated goals and score
        ui.DisplayGoals(goals);
        ui.DisplayScore(CalculateTotalScore(goals));

        //Saves and loads goals
        SaveGoals(goals, "goals.txt");
        goals = LoadGoals("goals.txt");

        //Displays loaded goals & score
        ui.DisplayGoals(goals);
        ui.DisplayScore(CalculateTotalScore(goals));
    }

     static int CalculateTotalScore(List<Goal> goals)
    {
        //Calculates the total score based on completed goals
        int totalScore = 0;
        foreach (var goal in goals)
        {
            if (goal.IsCompleted())
            {
                totalScore += goal.GetPoints();
            }
        }
        return totalScore;
    }

     static List<Goal> LoadGoals(string filename)
    {
        //Loads goals from a text file
        List<Goal> loadedGoals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            Goal goal = GoalFactory.CreateGoalFromRepresentation(line);
            loadedGoals.Add(goal);
        }
        Console.WriteLine($"Goals loaded from {filename}.");
        return loadedGoals;
    }

    
}