namespace Figurs;

public class Cicle : Figura
{
    private double Radius;

    public Cicle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override void Square()
    {
        double square = Math.PI * (Radius * Radius);
        System.Console.WriteLine(($"{this} square = {square:N2}"));
    }

    public override string ToString()
    {
        return $"Circle {Name}";
    }
}