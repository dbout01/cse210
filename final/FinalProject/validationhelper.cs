class ValidationHelper
{
    // Validates if the given year is within a reasonable range
    public bool ValidateYear(int year)
    {
        // Checks if the year is greater than or equal to 1900 and less than or equal to the current year
        return year >= 1900 && year <= DateTime.Now.Year;
    }

    // Validates if the given price is a positive value
    public bool ValidatePrice(decimal price)
    {
        // Checks if the price is greater than 0
        return price > 0;
    }

    // Validates if the given quantity is a non-negative value
    public bool ValidateQuantity(int quantity)
    {
        // Checks if the quantity is greater than or equal to 0
        return quantity >= 0;
    }
}