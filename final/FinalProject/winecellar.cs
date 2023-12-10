using System;
using System.Collections.Generic;

class WineCellar
{
    private List<Wine> wines = new List<Wine>();

    // Adds a wine to the cellar
    public void AddWine(Wine wine)
    {
        wines.Add(wine);
        Console.WriteLine($"Wine added to the cellar: {wine.Name}");
    }

    // Adds multiple wines to the cellar
    public void AddWines(List<Wine> newWines)
    {
        wines.AddRange(newWines);
        Console.WriteLine($"Wines added to the cellar.");
    }

    // Removes a wine from the cellar
    public void RemoveWine(Wine wine)
    {
        wines.Remove(wine);
        Console.WriteLine($"Wine removed from the cellar: {wine.Name}");
    }

    // Searches for wines in the cellar based on a keyword
    public List<Wine> SearchWine(string keyword)
    {
        // Using LINQ to find wines that match the keyword in the name or region
        List<Wine> searchResults = wines.FindAll(w => w.Name.Contains(keyword) || w.Region.Contains(keyword));
        
        // Display the search results
        Console.WriteLine($"Search results for '{keyword}':");
        foreach (var result in searchResults)
        {
            result.DisplayInformation();
        }

        return searchResults;
    }

    // Displays information for all wines in the cellar
    public void DisplayAllWines()
    {
        Console.WriteLine("All Wines in the Cellar:");
        foreach (var wine in wines)
        {
            wine.DisplayInformation();
        }
    }

    // Gets the list of wines in the cellar
    public List<Wine> GetWines()
    {
        return wines;
    }
}









// Principle: Abstraction
// This class represents a WineCellar, which is responsible for managing a collection of wines.
// It abstracts the storage and retrieval of wines, providing an organized way to interact with wines.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of the wine cellar are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on managing a collection of wines without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on managing a collection of wines.