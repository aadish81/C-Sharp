using System;

namespace InterfaceInCs{
    abstract class AbstractClass{
        public String hello;
        public abstract void Test();
    }
    public interface InterfaceOne{
        void Test();
    }
    public interface InterfaceTwo{
        void Test();
    }
    class Program : AbstractClass,InterfaceOne,InterfaceTwo{
        
        void InterfaceOne.Test(){
            Console.WriteLine("This is method from InerfaceOne");
        }
        void InterfaceTwo.Test(){
            Console.WriteLine("This is method from InterfaceTwo");
        }
        public override void Test(){
            Console.WriteLine("This is method from Abstract Class");
        }
        public static void Main(){
            Program obj = new Program();
            InterfaceOne i1 = obj;
            InterfaceTwo i2 = obj;
            obj.hello = "hello world";  
            Console.WriteLine(obj.hello);
            i1.Test();
            i2.Test();
            obj.Test();
        }
    }
}