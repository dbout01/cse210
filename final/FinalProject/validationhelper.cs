class ValidationHelper
{
    // Validate if the given year is within a reasonable range
    public bool ValidateYear(int year)
    {
        // Check if the year is greater than or equal to 1900 and less than or equal to the current year
        return year >= 1900 && year <= DateTime.Now.Year;
    }

    // Validate if the given price is a positive value
    public bool ValidatePrice(decimal price)
    {
        // Check if the price is greater than 0
        return price > 0;
    }

    // Validate if the given quantity is a non-negative value
    public bool ValidateQuantity(int quantity)
    {
        // Check if the quantity is greater than or equal to 0
        return quantity >= 0;
    }
}