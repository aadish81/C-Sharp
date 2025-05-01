using System;

// Enum Definition
public enum Department { HR, IT, Finance, Sales }

// Struct Definition
public struct EmployeeInfo
{
    public int Id;
    public string Name;
    public Department Dept;
}

// Partial Class (First Part)
public partial class Employee
{
    public EmployeeInfo Info;
    public void Display(){
        Console.WriteLine("ID: "+Info.Id);
        Console.WriteLine("Name: "+Info.Name);
        Console.WriteLine("Dept: "+Info.Dept);
    }
}

// Partial Class (Second Part)
public partial class Employee
{
    public void ShowDepartment() {
        Console.WriteLine("Department: "+Info.Dept);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Employee emp = new Employee { Info = new EmployeeInfo { Id = 101, Name = "Alice", Dept = Department.IT } };
        emp.Display();
        emp.ShowDepartment();
    }
}
