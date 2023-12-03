using System;

class Wine
{
    public string Name { get; set; }
    public int Year { get; set; }
    public string Type { get; set; }
    public string Region { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}, Year: {Year}, Type: {Type}, Region: {Region}, Price: {Price:C}, Quantity: {Quantity}");
    }

    public void UpdateQuantity(int quantity)
    {
        Quantity += quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}
