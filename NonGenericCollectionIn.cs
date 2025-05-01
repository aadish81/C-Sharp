using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList(); // Non-generic collection
        list.Add(10);       // Stores an int
        list.Add("Hello");   // Stores a string
        list.Add(5.5);       // Stores a double

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
