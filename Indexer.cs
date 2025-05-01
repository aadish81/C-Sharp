using System;
class IndexerInCS{
    static void Main(){
        intArray array = new intArray();
        array[0] = 5;
        array[2] = 15;
        Console.WriteLine("Element in first Position is: "+ array[0]);
        Console.WriteLine("Element in second Position is: "+ array[2]);
        Console.WriteLine();
        Employee emp = new Employee(2,"Anish","HR",500000.00);
        Console.WriteLine("ID of employee is: "+ emp[0]);
        Console.WriteLine("Name of employee is: "+ emp[1]);
        Console.WriteLine("Position of employee is: "+ emp[2]);
        Console.WriteLine("Salary of employee is: "+ emp[3]);


    }
}
//Indexer of type int
class intArray{
    
    private int[] array = new int[10];

    public int this[int index]{
        get{
            return array[index];
        }
        set{
            array[index] = value;
        }
    }
}
//Indexer of type object
class Employee{
    private int id;
    private String name;
    private String position;
    private double salary;

    public Employee(int id, String name, String position, double salary){
        this.id = id;
        this.name = name;
        this.position = position;
        this.salary = salary;
    }

    public object this[int i]{
            get{
                if(i == 0)
                    return id;
                else if(i==1)
                    return name;
                else if(i==2)
                    return position; 
                else if(i ==3 ) 
                    return salary;
                else
                    return null;          
                
                }
            set{
                if(i == 0)
                    id = (int)value;
                else if(i == 1)
                    name = (string)value;
                else if(i == 2)
                    position = (string)value;
                else if(i == 3)
                    salary = (double)value;
    
            }
            }
    }
    
