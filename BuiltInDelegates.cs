using System;

namespace BuiltInDelegates3{
    class Program{

        static void Main(){

            Func<int,int,int> obj1 = (a,b) =>{ return (a+b);};

            Console.WriteLine("Sum is: "+ obj1.Invoke(7,9));

            Action<int,int> obj2 = (a,b) => {
                Console.WriteLine("Product is: "+ (a+b));
            };
            obj2.Invoke(7,4);
        }
    }
}
