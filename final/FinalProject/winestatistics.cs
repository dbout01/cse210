using System;
using System.Collections.Generic;
using System.Linq;

class WineStatistics
{
    private List<Wine> wines;

    // Constructor to initialize the WineStatistics object with a list of wines
    public WineStatistics(List<Wine> wines)
    {
        this.wines = wines;
    }

    // Calculate the average price of all wines
    public double CalculateAveragePrice()
    {
        // Check if there are wines in the list
        if (wines.Count == 0)
        {
            return 0; // Return 0 if there are no wines
        }

        // Use LINQ to calculate the average price
        double totalPrices = wines.Sum(wine => (double)wine.Price);
        return totalPrices / wines.Count;
    }

    // Find the oldest wine in the list
    public Wine FindOldestWine()
    {
        // Check if there are wines in the list
        if (wines.Count == 0)
        {
            return null; // Return null if there are no wines
        }

        // Use LINQ to find the wine with the earliest year
        return wines.OrderBy(wine => wine.Year).First();
    }

    // Find the newest wine in the list
    public Wine FindNewestWine()
    {
        // Check if there are wines in the list
        if (wines.Count == 0)
        {
            return null; // Return null if there are no wines
        }

        // Use LINQ to find the wine with the latest year
        return wines.OrderByDescending(wine => wine.Year).First();
    }
}