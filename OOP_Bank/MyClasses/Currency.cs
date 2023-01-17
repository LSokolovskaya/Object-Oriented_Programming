namespace OOP_Bank.MyClasses;

public class Currency
{
    public int Code { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string ShortName { get; set; }

    public Currency()
    {

    }

    public Currency(int code, string name, string symbol, string shortName)
    {
        Code = code;
        Name = name;
        Symbol = symbol;
        ShortName = shortName;
    }

    public override string ToString()
    {
        return $"{Name} ({ShortName})";
    }
}


