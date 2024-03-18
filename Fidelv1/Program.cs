using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the path of the program/file you want to open:");
        string filePath = Console.ReadLine();

        // Check if the file or program exists
        if (!System.IO.File.Exists(filePath) && !System.IO.Directory.Exists(filePath))
        {
            Console.WriteLine("File or program not found!");
            return;
        }

        try
        {
            // Start the process
            Process.Start(filePath);
            Console.WriteLine("Program/File opened successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.ReadLine(); // Keep the console window open
    }
}
