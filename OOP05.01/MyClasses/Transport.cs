namespace MyClasses.Transport;
public class Transport
{
    public double Speed;
    public string Name;

    public Transport(double speed, string name) : this(name)
    {
        Speed = speed;
    }
    public Transport( string name)
    {
        Name = name;
    }
    public void Moving()
    {
        System.Console.WriteLine($"{Name} Moving");
    }
    public void Stopping()
    {
        System.Console.WriteLine($"{Name} Stopping");
    }
}