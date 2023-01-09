namespace MyClasses.Cars;
public class Van : Car
{
    
    public override void Moving() 
    {
        System.Console.WriteLine($"Car '{Name}' moving");
    }

    public Van(string name) : base(name)
    {

    }
}