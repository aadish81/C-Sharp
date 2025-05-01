using System;

namespace LemdaExpression{
    public delegate void SayHello(String name);
    class Program{

        static void Main(){
            
            SayHello obj = (name) => 
            {
                Console.WriteLine("Hello, "+ name +" a very good morning!");
            };
            obj.Invoke("Suresh");
        }
    }
}

