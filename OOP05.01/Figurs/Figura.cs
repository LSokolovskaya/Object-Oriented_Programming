namespace Figurs;

public class Figura
{
    public string Name
    {
        get;
        private set;
    }

    public Figura(string name)
    {
        Name = name;
    }

    public virtual void Square()
    {
        System.Console.WriteLine($"{Name} error square ");
    }
}