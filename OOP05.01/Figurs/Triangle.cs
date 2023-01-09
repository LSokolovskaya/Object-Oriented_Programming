namespace Figurs;

public class Triangle : Figura
{
    private double SideA;
    private double SideB;
    private double SideC;

    public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override void Square()
    {
        double p = (SideA + SideB + SideC) / 2;
        double square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        System.Console.WriteLine(($"{this} square = {square}"));
    }

    public override string ToString()
    {
        return $"Triangle {Name}";
    }
}