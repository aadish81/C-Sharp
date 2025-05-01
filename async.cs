using System;
using System.Threading.Tasks;

class Program
{
    static async Task FetchData()
    {
        Console.WriteLine("Fetching data... Please wait.");
        
        // Simulating a time-consuming task (like fetching data from a database or API)
        await Task.Delay(3000);

        Console.WriteLine("Data fetched successfully!");
    }

    static void Main()
    {
        Console.WriteLine("Starting application...");
        
        // Call the asynchronous method
        FetchData();

        Console.WriteLine("Processing completed.");
    }
}
