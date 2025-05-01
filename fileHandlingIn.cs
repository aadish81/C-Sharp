using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt"; // Define file name

        Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") // Stop when user types 'exit'
                    break;
                
                writer.WriteLine(input); // Write input to file
            }
        }

        Console.WriteLine("Text has been saved to "+ filePath);
    }
}
