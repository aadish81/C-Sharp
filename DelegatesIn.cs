using System;

namespace Delegates{
    public delegate void Calculate(double a,double b);
    class Program{

        public void add(double a,double b){
            Console.WriteLine("Addition: " + (a+b));
        }
        public void multiply(double a,double b){
            Console.WriteLine("Multiplication: "+ (a*b));
        }
        static void Main(){

            Program p1 = new Program();
            Calculate c1 = p1.add;
            c1 += p1.multiply;
            
            c1.Invoke(6.0,9.0);
        }
    }

}