using System;
using System.IO;
using System.Text;

class FileHandler
{
    // Saves data to a file
    public void SaveToFile(string filename, string data)
    {
        try
        {
            // Combines the filename with the current directory to get the full path
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            // Writes the data to the file using UTF-8 encoding
            File.WriteAllText(filePath, data, Encoding.UTF8);

            // Displays a success message
            Console.WriteLine($"Data saved to file: {filePath}");
        }
        catch (Exception ex)
        {
            // Handles exceptions and display an error message
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    // Loads data from a file
    public string LoadFromFile(string filename)
    {
        try
        {
            // Combines the filename with the current directory to get the full path
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            // Checks if the file exists
            if (File.Exists(filePath))
            {
                // Reads the data from the file using UTF-8 encoding
                string data = File.ReadAllText(filePath, Encoding.UTF8);

                // Displays a success message
                Console.WriteLine($"Data loaded from file: {filePath}");

                // Returns the loaded data
                return data;
            }
            else
            {
                // Displays a message if the file is not found
                Console.WriteLine($"File not found: {filePath}");

                // Returns an empty string
                return string.Empty;
            }
        }
        catch (Exception ex)
        {
            // Handles exceptions and display an error message
            Console.WriteLine($"Error loading from file: {ex.Message}");

            // Returns an empty string
            return string.Empty;
        }
    }
}









// Principle: Abstraction
// This class represents FileHandler, which handles file operations for the wine cellar management system.
// It abstracts the details of file handling, providing a centralized way to save and load data.

// Principle: Encapsulation
// All member variables are private, and public methods are defined for necessary behaviors.
// Encapsulation ensures that the internal details of file handling are hidden from external classes.

// Principle: Inheritance
// No explicit inheritance is needed in this class, as it focuses on file handling without shared behaviors.

// Principle: Polymorphism
// No explicit polymorphism is required in this class, as it primarily focuses on file handling.