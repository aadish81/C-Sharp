using System;

class AgeException : Exception
{
    public AgeException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new AgeException("Age restriction: Must be 18 or older.");
        }
        Console.WriteLine("Access granted.");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Error: "+ex.Message);
        }
    }
}
