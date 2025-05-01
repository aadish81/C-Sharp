using System;

// Step 1: Define Custom Attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class InfoAttribute : Attribute
{
    public string Author { get;set; }
    public string Version { get;set; }

    public InfoAttribute(string author, string version)
    {
        Author = author;
        Version = version;
    }
}

// Step 2: Apply Custom Attribute
[Info("John Doe", "1.0")]
class SampleClass
{
    [Info("Jane Doe", "1.1")]
    public void SampleMethod() { }
}

// Step 3: Read Attribute at Runtime
class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        var attributes = type.GetCustomAttributes(typeof(InfoAttribute), false);

        foreach (InfoAttribute attr in attributes)
        {
            Console.WriteLine("Class Info - Author: "+attr.Author +" Version: "+attr.Version);
        }
    }
}
