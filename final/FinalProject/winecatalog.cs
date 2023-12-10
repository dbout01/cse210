using System;
using System.Collections.Generic;

class WineCatalog
{
    // List to store wines in the catalog
    private List<Wine> catalogWines;

    // Constructor to initialize the WineCatalog with sample data
    public WineCatalog()
    {
        // Initialize the catalog with some sample wines
        catalogWines = new List<Wine>
        {
            new Wine { Name = "Chateau Margaux", Year = 2010, Type = "Red", Region = "Bordeaux", Price = 500, Quantity = 10 },
            new Wine { Name = "Opus One", Year = 2015, Type = "Red", Region = "Napa Valley", Price = 350, Quantity = 8 },
            new Wine { Name = "Chardonnay Reserve", Year = 2018, Type = "White", Region = "California", Price = 40, Quantity = 15 },
            // Add more wines as needed
        };
    }

    // Method to retrieve the catalog of wines
    public List<Wine> GetCatalog()
    {
        // Return the list of wines in the catalog
        return catalogWines;
    }

    // Additional methods can be added to manage the catalog, such as adding, removing, or searching for wines.
}