using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>(); // Generic collection
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
