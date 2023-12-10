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

    // Display information about the wine
    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Year: {Year}, Type: {Type}, Region: {Region}, Price: {Price:C}, Quantity: {Quantity}");
    }

    // Update the quantity of bottles in the cellar
    public void UpdateQuantity(int quantity)
    {
        Quantity += quantity;
    }

    // Calculate the total price of all bottles in the cellar
    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}