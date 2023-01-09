namespace Figurs;

public class Rectangle : Figura
{
    private double WidthA;
    private double WidthB;

    public Rectangle(string name, double widthA, double widthB) : base(name)
    {
        WidthA = widthA;
        WidthB = widthB;
    }

    public override void Square()
    {
        double square = WidthA + WidthB;
        System.Console.WriteLine(($"{this} square = {square}"));
    }

    public override string ToString()
    {
        return $"Rectangle {Name}";
    }
}