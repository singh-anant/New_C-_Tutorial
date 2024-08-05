class Vehicle{
    protected string Make{get;set;}
    protected string Model{get;set;}
     protected DateTime DateOfRegistration { get; set; }

    public Vehicle(string make, string model, DateTime dateOfRegistration)
    {
        Make = make;
        Model = model;
        DateOfRegistration = dateOfRegistration;
    }
    public virtual void StartEngine(){
        System.Console.WriteLine("Base Class Vehicle has just started...");
    }

    public virtual void StopEngine(){
        System.Console.WriteLine("Base Class Vehicle has just stopped...");
    }
    


    public void GetTheName(){
        System.Console.WriteLine($"The name of the car is {Make} {Model}");
    }
}

class Car:Vehicle{
     public int NumOfDoors{get;set;}

    public Car(string make, string model, DateTime dateOfRegistration, int numOfDoors)
        : base(make, model, dateOfRegistration)
    {
        NumOfDoors = numOfDoors;
    }

    public override void StartEngine()
    {
        //base.StartEngine();
        Console.WriteLine("Child Class Car has just started...");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Child Class Car has just stopped...");
    }

    public  void ParallelParking(){
        System.Console.WriteLine("Child class Car can do parallel park...");
    }
}

// public class ElectricalCar:Vehicle{
//     public int BatteryCapacity{get;set;}
// }
class Program{
    static void Main(string[] args){
        //ways to call base class methods....
        Vehicle cr=new Car("Tata","Harrier",new DateTime(2022, 1, 1),3);
       cr.StartEngine();
        cr.StopEngine();
        cr.
    }
}