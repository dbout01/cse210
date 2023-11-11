using System;
using System.Collections.Generic;
using System.IO;



// Represents a date with a method to get a formatted string
public class Date
{
    public string ToShortDateString()
    {
        return DateTime.Now.ToShortDateString();
    }
}



// Represents an individual journal entry with date, prompt, and content
public class Entry
{
    private Date _date;
    private string _prompt;
    private string _content;

    
    // Constructor to create an entry with date, prompt, and content
    public Entry(Date date, string prompt, string content)
    {
        _date = date;
        _prompt = prompt;
        _content = content;
    }

    // Returns the date of the entry
    public Date GetDate()
    {
        return _date;
    }

    // Returns the prompt associated with the entry
    public string GetPrompt()
    {
        return _prompt;
    }

    // Returns the content of the entry
    public string GetContent()
    {
        return _content;
    }
}



// Represents a journal containing a list of entries
public class Journal
{
    private List<Entry> _entries;

    // Constructor to create a journal with an empty list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adds a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Returns the list of entries in the journal
    public List<Entry> GetEntries()
    {
        return _entries;
    }

    // Saves the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                string entryData = $"{entry.GetDate().ToShortDateString()}|{entry.GetPrompt()}|{entry.GetContent()}";
                outputFile.WriteLine(entryData);
            }
        }
    }

    // Loads the journal from a file, replacing any existing entries
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clears existing entries before loading from file

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Date date = new Date();
            string prompt = parts[1];
            string content = parts[2];

            Entry entry = new Entry(date, prompt, content);
            _entries.Add(entry);
        }
    }
}

// Generates prompts and allows retrieving a random prompt
public class PromptGenerator
{
    private List<string> _prompts;

    // Constructor to initialize with a list of prompts
    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    // Generates and returns a random prompt
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

// Main program class
class Program
{
    static void Main()
    {
        // Custom prompts
        List<string> prompts = new List<string>
        {
            "Describe a small act of kindness you witnessed or performed today.",
            "Reflect on a moment that challenged your perspective or changed your mindset.",
            "Share an achievement, no matter how small, that made you proud today.",
            "Explore a goal or aspiration you have for the future and what steps you took today to work towards it.",
        };

        PromptGenerator promptGenerator = new PromptGenerator(prompts);
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");

                    Console.Write("Enter your response: ");
                    string userResponse = Console.ReadLine();

                    Date currentDate = new Date();
                    Entry newEntry = new Entry(currentDate, randomPrompt, userResponse);

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    foreach (Entry entry in journal.GetEntries())
                    {
                        Console.WriteLine($"Date: {entry.GetDate().ToShortDateString()} - Prompt: {entry.GetPrompt()} - Response: {entry.GetContent()}");
                    }
                    break;
                case "3":
                    Console.Write("Enter a filename to save the journal: ");
                    string filenameToSave = Console.ReadLine();
                    journal.SaveToFile(filenameToSave);
                    break;
                case "4":
                    Console.Write("Enter a filename to load the journal from: ");
                    string filenameToLoad = Console.ReadLine();
                    journal.LoadFromFile(filenameToLoad);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}