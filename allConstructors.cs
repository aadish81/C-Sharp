using System ;

class Question1{
    static void Main(){
    
        //Parameterized Constructor
        Tesla tesla1 = new Tesla("Model Y","$53,990");
        tesla1.Introduce();

        RollsRoyce royce1 = new RollsRoyce("Cullinan","$392,000");
        RollsRoyce royce2 = new RollsRoyce(royce1);
        royce2.Introduce();

        
        Lambo.name = "Reveulto";
        Lambo.price = "$608,358";
        Lambo.IntroduceLambo();

        Bugatti bugatti = new Bugatti("W16 Mistral","$5,379,750");
        Console.WriteLine("Bugatti, "+ Bugatti.tagline);
        bugatti.Introduce();


    }
}
//Default Constructor
class Car{
    public  String  name;
    public  String price;
    public virtual void Introduce(){
        
    }
}
//Parameterized Constructor
class Tesla : Car{

    public Tesla(String name,String price){
        this.name = name;
        this.price = price;
    }
    public override void Introduce(){
        Console.WriteLine("Tesla:" + this.name + " Cost: " + this.price);
    }
}    
//Copy Constructor 
class RollsRoyce:Car{
    
    public RollsRoyce(RollsRoyce car1){
        name = car1.name;
        price = car1.price;

    }
    public RollsRoyce(String name , String price){
        this.name = name;
        this.price =price;
    }
    public override void Introduce(){
        Console.WriteLine("Roll-Royce:" + this.name + " Cost: " + this.price);
    }
} 
//Private Constructor
class Lambo{

    private Lambo(){

    }
    public static String name;
    public static String price;
    public  static void IntroduceLambo(){
        Console.WriteLine("Lamborghini:"+name+" Cost: "+price);
    }
}
//Static Constructor
class Bugatti:Car{
    public static String tagline;
    static Bugatti(){
        tagline = "Create the Incomparable";

    }
        public Bugatti(String name,String price){
        this.name = name;
        this.price = price;
    }
    public override void Introduce(){
        Console.WriteLine("Bugatti:" + this.name + " Cost: " + this.price);
    }

}

