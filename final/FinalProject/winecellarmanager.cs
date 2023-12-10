using System;
using System.Collections.Generic;

class WineCellarManager
{
    private WineCellar wineCellar = new WineCellar();
    private WineCatalog wineCatalog = new WineCatalog();
    private WineStatistics wineStatistics;
    private FileHandler fileHandler = new FileHandler();
    private UserInterface userInterface = new UserInterface();
    private ValidationHelper validationHelper = new ValidationHelper();

    // Main program logic
    public void RunProgram()
    {
        // Loads initial wines from the catalog
        List<Wine> catalogWines = wineCatalog.GetCatalog();
        wineCellar = new WineCellar();
        wineCellar.AddWines(catalogWines);

        bool exitProgram = false;

        // Main program loop
        do
        {
            // Displays the main menu and get user input
            userInterface.DisplayMenu();
            string userInput = userInterface.GetUserInput();

            // Processes user input based on the chosen menu option
            switch (userInput)
            {
                case "1":
                    AddWine();
                    break;
                case "2":
                    RemoveWine();
                    break;
                case "3":
                    SearchWines();
                    break;
                case "4":
                    DisplayAllWines();
                    break;
                case "5":
                    ViewWineStatistics();
                    break;
                case "6":
                    exitProgram = true;
                    break;
                default:
                    userInterface.DisplayErrorMessage("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }

        } while (!exitProgram);
    }

    // Logic to add a wine to the cellar
    private void AddWine()
    {
        // Implement logic to add a wine to the cellar
    }

    // Logic to remove a wine from the cellar
    private void RemoveWine()
    {
        // Implement logic to remove a wine from the cellar
    }

    // Logic to search for wines in the cellar
    private void SearchWines()
    {
        // Implement logic to search for wines in the cellar
    }

    // Logic to display all wines in the cellar
    private void DisplayAllWines()
    {
        // Implement logic to display all wines in the cellar
    }

    // Logic to display wine statistics
    private void ViewWineStatistics()
    {
        // Implement logic to display wine statistics
        if (wineStatistics == null)
        {
            wineStatistics = new WineStatistics(wineCellar.GetWines());
        }

        Console.WriteLine($"Average Price: {wineStatistics.CalculateAveragePrice():C}");
        Wine oldestWine = wineStatistics.FindOldestWine();
        Console.WriteLine($"Oldest Wine: {oldestWine?.Name}, Year: {oldestWine?.Year}");
        Wine newestWine = wineStatistics.FindNewestWine();
        Console.WriteLine($"Newest Wine: {newestWine?.Name}, Year: {newestWine?.Year}");
    }
}









// Principle: Abstraction
// This class represents WineCellarManager, the main program manager for the wine cellar management system.
// It abstracts the details of program flow, providing a structured way to manage the wine cellar system.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of program management are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on program management without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on program management.