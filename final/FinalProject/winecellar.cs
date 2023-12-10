using System;
using System.Collections.Generic;

class WineCellar
{
    private List<Wine> wines = new List<Wine>();

    // Add a wine to the cellar
    public void AddWine(Wine wine)
    {
        wines.Add(wine);
        Console.WriteLine($"Wine added to the cellar: {wine.Name}");
    }

    // Add multiple wines to the cellar
    public void AddWines(List<Wine> newWines)
    {
        wines.AddRange(newWines);
        Console.WriteLine($"Wines added to the cellar.");
    }

    // Remove a wine from the cellar
    public void RemoveWine(Wine wine)
    {
        wines.Remove(wine);
        Console.WriteLine($"Wine removed from the cellar: {wine.Name}");
    }

    // Search for wines in the cellar based on a keyword
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

    // Display information for all wines in the cellar
    public void DisplayAllWines()
    {
        Console.WriteLine("All Wines in the Cellar:");
        foreach (var wine in wines)
        {
            wine.DisplayInformation();
        }
    }

    // Get the list of wines in the cellar
    public List<Wine> GetWines()
    {
        return wines;
    }
}