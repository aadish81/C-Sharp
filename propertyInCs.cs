using System ;

class qsnNo2{

    static void Main(){
        Bugatti car1 = new Bugatti("noModelSelected");
        car1.Model = "La Voiture Noire";
        Console.WriteLine("The model you choose is: "+ car1.Model);

        RollsRoyce car2 = new RollsRoyce("notSpecified");
        car2.model = "Rolls-Royce Phantom";
        Console.WriteLine("The model you choose is: "+car2.model);

        Lambo car3 = new Lambo();
        Console.WriteLine("The model you have is: "+car3.Model);


    }
}
//Property in c#
class Bugatti{

    private String model;

    public Bugatti(String model){
        this.model = model;
    }

    public String Model{
        get{return model;}
        set{
            model = value;
        }
    }
}
// Auto-Implemented Property in c#
class RollsRoyce{

    public String model{get; set;}

    public RollsRoyce(String model){
        this.model = model;
    }
    
}
//Read-Only Property in c#
class Lambo{

    private String model;

    public Lambo(){
        model = "Lamborghini Huracan";
    }
    public String Model{
        get{
            return model;
        }
    }

}