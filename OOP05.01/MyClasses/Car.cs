namespace MyClasses.Cars;
public class Car : MyClasses.Transport.Transport
{
    public int Type { get; set; }

    public Car(double speed, string name, int type) : base(speed, name)
    {
        Type = type;
    }
    public Car(string name, int type) : base(name)
    {
        Type = type;
    }

    public Car(string name) : base(name)
    {

    }

    public void Drift()
    {
        System.Console.WriteLine($"{Name} is breaking");
    }
}