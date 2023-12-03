class ValidationHelper
{
    public bool ValidateYear(int year)
    {
        return year >= 1900 && year <= DateTime.Now.Year;
    }

    public bool ValidatePrice(decimal price)
    {
        return price > 0;
    }

    public bool ValidateQuantity(int quantity)
    {
        return quantity >= 0;
    }
}
