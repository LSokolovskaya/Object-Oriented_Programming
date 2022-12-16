namespace Task_OOP_2.MyClasses;
public class Phone
{
    public string Number = "+375-XX-YYY-YY-YY";
    public string Model = "Phone";
    public string Weight = "Empty";

    public Phone()
    {

    }

    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }

    public Phone(string number, string model, string weight) : this(number, model)
    {
        Weight = weight;
    }

    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }
    public void ReceiveCall(string name, string number)
    {
        Console.WriteLine($"Звонит {name} с номера {number}");
    }
    public static void SendMessedge(string messedge = "Hello", params string[] numbers)
    {
        foreach (string item in numbers)
        {
            System.Console.WriteLine((string.Format("Phone: {0} messedge: {1}", item, messedge)));
        }
    }
    public string GetNumber()
    {
        return Number;
    }

    public override string ToString()
    {
        return string.Join(",", Number, Model, Weight);
    }
}