using System;
using System.Collections.Generic;

class WineCatalog
{
    // Lists to store wines in the catalog
    private List<Wine> catalogWines;

    // Constructor to initialize the WineCatalog with sample data
    public WineCatalog()
    {
        // Initializes the catalog with some sample wines
        catalogWines = new List<Wine>
        {
            new Wine { Name = "Chateau Margaux", Year = 2010, Type = "Red", Region = "Bordeaux", Price = 500, Quantity = 10 },
            new Wine { Name = "Opus One", Year = 2015, Type = "Red", Region = "Napa Valley", Price = 350, Quantity = 8 },
            new Wine { Name = "Chardonnay Reserve", Year = 2018, Type = "White", Region = "California", Price = 40, Quantity = 15 },
            new Wine { Name = "Barolo", Year = 2012, Type = "Red", Region = "Piedmont", Price = 250, Quantity = 12 },
            new Wine { Name = "Sauvignon Blanc", Year = 2019, Type = "White", Region = "Marlborough", Price = 30, Quantity = 20 },
            new Wine { Name = "Rioja Reserva", Year = 2014, Type = "Red", Region = "Rioja", Price = 45, Quantity = 18 },
            new Wine { Name = "Merlot", Year = 2017, Type = "Red", Region = "California", Price = 35, Quantity = 25 },
            new Wine { Name = "Pinot Grigio", Year = 2020, Type = "White", Region = "Veneto", Price = 25, Quantity = 22 },
            new Wine { Name = "Cabernet Sauvignon", Year = 2016, Type = "Red", Region = "Napa Valley", Price = 55, Quantity = 14 },
            new Wine { Name = "Riesling", Year = 2015, Type = "White", Region = "Mosel", Price = 28, Quantity = 30 },
            new Wine { Name = "Malbec", Year = 2013, Type = "Red", Region = "Mendoza", Price = 42, Quantity = 16 },
            new Wine { Name = "Chablis", Year = 2018, Type = "White", Region = "Burgundy", Price = 38, Quantity = 18 },
            new Wine { Name = "Zinfandel", Year = 2016, Type = "Red", Region = "Sonoma", Price = 40, Quantity = 12 },
        };
    }

    // Method to retrieve the catalog of wines
    public List<Wine> GetCatalog()
    {
        // Returns the list of wines in the catalog
        return catalogWines;
    }
}









// Principle: Abstraction
// This class represents a WineCatalog, which is responsible for managing a catalog of wines.
// It abstracts the organization of wine data, providing a structured way to access information about available wines.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of the wine catalog are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on managing a catalog of wines without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on managing a catalog of wines.