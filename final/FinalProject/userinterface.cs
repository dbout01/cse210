using System;

class UserInterface
{
    // Displays the main menu for the user
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

    // Gets user input from the console
    public string GetUserInput()
    {
        return Console.ReadLine();
    }

    // Displays an error message to the user
    public void DisplayErrorMessage(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
}









// Principle: Abstraction
// This class represents UserInterface, which provides a user interface for the wine cellar management system.
// It abstracts the details of user interaction, providing a structured way to display menus and gather input.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of user interface management are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on user interface management without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on user interface management.