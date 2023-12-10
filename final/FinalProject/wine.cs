using System;

// Represents a bottle of wine
class Wine
{
    // Properties to store information about the wine
    public string Name { get; set; }       // Name of the wine
    public int Year { get; set; }          // Year the wine was produced
    public string Type { get; set; }       // Type of wine (Red, White)
    public string Region { get; set; }     // Region where the wine is produced
    public decimal Price { get; set; }     // Price of the wine
    public int Quantity { get; set; }      // Quantity of bottles in the cellar

    // Displays information about the wine
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Year: {Year}, Type: {Type}, Region: {Region}, Price: {Price:C}, Quantity: {Quantity}");
    }

    // Updates the quantity of bottles in the cellar
    public void UpdateQuantity(int quantity)
    {
        Quantity += quantity;
    }

    // Calculates the total price of all bottles in the cellar
    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}









// Principle: Abstraction
// This class represents a Wine entity with properties for its name, year, type, region, price, and quantity.
// It encapsulates the details of a wine and provides abstraction for other classes to interact with wine objects.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of a wine are hidden from external classes, promoting data integrity.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on representing the properties of a wine.