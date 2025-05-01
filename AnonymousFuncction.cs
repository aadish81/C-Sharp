using System;

namespace AnonymousFunc{
    public delegate String HelloDelegate(String name);
    class Program{

        static void Main(){
            
            Program obj = new Program();

            HelloDelegate h1 = delegate(String name){
                return "Hello, "+ name;
            };
            Console.WriteLine(h1.Invoke("Peter"));

        }
    }
}