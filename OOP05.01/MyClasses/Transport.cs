namespace MyClasses.Transport;
public class Transport
{
    public double Speed;
    public virtual string Name { get; set; }

    public Transport(double speed, string name) : this(name)
    {
        Speed = speed;
    }
    public Transport(string name)
    {
        Name = name;
    }
    public virtual void Moving()
    {
        System.Console.WriteLine($"Transport '{Name}' moving");
    }
    public void Stopping()
    {
        System.Console.WriteLine($"{Name} Stopping");
    }
}