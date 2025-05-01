using System;

namespace PolymorphishInCs{
    class BaseClass
    {
        public void SayHello(){
            Console.WriteLine("Hello! form Base Class");
        }
        public virtual void SayBye(){
            Console.WriteLine("This is Good Bye form Base Class");
        } 
    }
    class DerivedClass:BaseClass
    {
        public new void SayHello(){
            Console.WriteLine("This is Hello! form Child Class");
        }
        public override void SayBye(){
            Console.WriteLine("This is Good Bye form Child Class");
        }

        public static void Main(){
            BaseClass obj0 = new BaseClass();
            obj0.SayHello();
            DerivedClass obj1 = new DerivedClass();
            obj1.SayHello();
            obj1.SayBye();

            BaseClass obj2 = new DerivedClass();
            obj2.SayHello();
            obj2.SayBye();
            
        }
    }
}