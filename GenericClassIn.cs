using System;

class Box<T> // Generic class with type parameter <T>
{
    private T value; // Generic field

    public void SetValue(T val)
    {
        value = val;
    }

    public T GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();  // Using int type
        intBox.SetValue(100);
        Console.WriteLine(intBox.GetValue());  // Output: 100

        Box<string> strBox = new Box<string>();  // Using string type
        strBox.SetValue("Hello, Generics!");
        Console.WriteLine(strBox.GetValue());  // Output: Hello, Generics!
    }
}
