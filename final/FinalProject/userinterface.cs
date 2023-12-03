using System;

class UserInterface
{
    public void DisplayMenu()
    {
        // *add menu display*
    }

    public string GetUserInput()
    {
        return Console.ReadLine(); // Placeholder return
    }

    public void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
}
