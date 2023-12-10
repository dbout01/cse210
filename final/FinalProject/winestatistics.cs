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

    // Calculates the average price of all wines
    public double CalculateAveragePrice()
    {
        // Checks if there are wines in the list
        if (wines.Count == 0)
        {
            return 0; // Return 0 if there are no wines
        }

        // Uses LINQ to calculate the average price
        double totalPrices = wines.Sum(wine => (double)wine.Price);
        return totalPrices / wines.Count;
    }

    // Finds the oldest wine in the list
    public Wine FindOldestWine()
    {
        // Checks if there are wines in the list
        if (wines.Count == 0)
        {
            return null; // Return null if there are no wines
        }

        // Uses LINQ to find the wine with the earliest year
        return wines.OrderBy(wine => wine.Year).First();
    }

    // Finds the newest wine in the list
    public Wine FindNewestWine()
    {
        // Checks if there are wines in the list
        if (wines.Count == 0)
        {
            return null; // Return null if there are no wines
        }

        // Uses LINQ to find the wine with the latest year
        return wines.OrderByDescending(wine => wine.Year).First();
    }
}









// Principle: Abstraction
// This class represents WineStatistics, which calculates statistics about a collection of wines.
// It abstracts the logic for calculating average price, finding the oldest and newest wines.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of the wine statistics calculation are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on statistical calculations without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on statistical calculations.