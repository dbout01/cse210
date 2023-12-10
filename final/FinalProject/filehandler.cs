using System;
using System.IO;
using System.Text;

class FileHandler
{
    // Save data to a file
    public void SaveToFile(string filename, string data)
    {
        try
        {
            // Combine the filename with the current directory to get the full path
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            // Write the data to the file using UTF-8 encoding
            File.WriteAllText(filePath, data, Encoding.UTF8);

            // Display a success message
            Console.WriteLine($"Data saved to file: {filePath}");
        }
        catch (Exception ex)
        {
            // Handle exceptions and display an error message
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    // Load data from a file
    public string LoadFromFile(string filename)
    {
        try
        {
            // Combine the filename with the current directory to get the full path
            string filePath = Path.Combine(Environment.CurrentDirectory, filename);

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the data from the file using UTF-8 encoding
                string data = File.ReadAllText(filePath, Encoding.UTF8);

                // Display a success message
                Console.WriteLine($"Data loaded from file: {filePath}");

                // Return the loaded data
                return data;
            }
            else
            {
                // Display a message if the file is not found
                Console.WriteLine($"File not found: {filePath}");

                // Return an empty string
                return string.Empty;
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions and display an error message
            Console.WriteLine($"Error loading from file: {ex.Message}");

            // Return an empty string
            return string.Empty;
        }
    }
}