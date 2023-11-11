using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts;

    public ListingActivity(int durationInSeconds, List<string> listingPrompts) 
        : base("Listing Activity", "List as many things as you can based on the prompt.", durationInSeconds)
    {
        _listingPrompts = listingPrompts;
    }

    public void StartListingActivity()
    {
        DisplayStartingMessage();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.WriteLine("Start listing items...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(DurationInSeconds);

        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"Number of items listed: {itemCount}");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _listingPrompts[new Random().Next(_listingPrompts.Count)];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Example usage of activities
        BreathingActivity breathingActivity = new BreathingActivity(60);
        breathingActivity.StartBreathingActivity();

        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };
        ReflectionActivity reflectionActivity = new ReflectionActivity(90, reflectionPrompts);
        reflectionActivity.StartReflectionActivity();

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?"
        };
        ListingActivity listingActivity = new ListingActivity(120, listingPrompts);
        listingActivity.StartListingActivity();
    }
}