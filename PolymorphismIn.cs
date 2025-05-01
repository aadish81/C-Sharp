using System;

public class Polymorph{
    public static void Main(){
        Cat cat = new Cat();
        Dog dog = new Dog();
        Cow cow = new Cow();

        cat.name = "Kitty";
        dog.name = "Rocky";
        cow.name = "Princess";

        cat.Can();
        dog.Can();
        cow.Can();
    }

}
class Animal{
    public String  name;
    public virtual void Can(){

    }
}
class Dog:Animal{
    public override void Can(){
        Console.WriteLine(name + " can bark!!!");
    }
}
class Cat:Animal {
    public override void Can(){
        Console.WriteLine(name + " can Meow!!!");
    }
}
class Cow:Animal {
    public override void Can(){
        Console.WriteLine(name + " can Baa!!");
    }
}