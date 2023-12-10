using System;

class UserInterface
{
    // Display the main menu for the user
    public void DisplayMenu()
    {
        Console.WriteLine("===== Wine Cellar Management System =====");
        Console.WriteLine("1. Add Wine");
        Console.WriteLine("2. Remove Wine");
        Console.WriteLine("3. Search Wines");
        Console.WriteLine("4. Display All Wines");
        Console.WriteLine("5. Wine Statistics");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice (1-6): ");
    }

    // Get user input from the console
    public string GetUserInput()
    {
        return Console.ReadLine();
    }

    // Display an error message to the user
    public void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
}