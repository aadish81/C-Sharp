using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample data: List of numbers
        List<int> numbers = new List<int> { 10, 3, 45, 7, 19, 8, 2, 50 };

        // LINQ Query Syntax: Get numbers greater than 10 and sort them
        var filteredNumbers = from n in numbers
                              where n > 10
                              orderby n
                              select n;

        // Display results
        Console.WriteLine("Numbers greater than 10 (sorted):");
        foreach (var num in filteredNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
