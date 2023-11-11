using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts;

    public ReflectionActivity(int durationInSeconds, List<string> reflectionPrompts) 
        : base("Reflection Activity", "Reflect on times when you showed strength and resilience.", durationInSeconds)
    {
        _reflectionPrompts = reflectionPrompts;
    }

    public void StartReflectionActivity()
    {
        DisplayStartingMessage();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        foreach (var question in _reflectionPrompts)
        {
            Console.WriteLine($"Question: {question}");
            PauseWithSpinner(3);
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _reflectionPrompts[new Random().Next(_reflectionPrompts.Count)];
    }
}
