using System;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Money dollar = new Money()
        {
            Code = 177,
            Name = "dollar",
            Symbol = "$"
        };

        Money byn = new Money();
        byn.Code = 667;
        byn.Name = "Belarusian rub";
        byn.Symbol = "Br";

        Console.WriteLine(dollar);
        Console.WriteLine(byn);
        Console.WriteLine("----JsonSerializer.Serialize----");
        string jsondollar = JsonSerializer.Serialize(dollar);
        Console.WriteLine(jsondollar);
        string jsonbyn = JsonSerializer.Serialize(byn);
        Console.WriteLine(jsonbyn);
        Console.WriteLine("----JsonSerializer.Serialize----");
        Money? newDollar = JsonSerializer.Deserialize<Money>(jsondollar);
        Console.WriteLine(newDollar);
        Money? newByn = JsonSerializer.Deserialize<Money>(jsonbyn);
        Console.WriteLine(newByn);
        Console.WriteLine("----Custome----");
        var serializeoption = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        string json = "{\"Code\":177,\"Name\":\"dollar\",\"Symbol\":\"$\"}";
        try
        {
            Money? test = JsonSerializer.Deserialize<Money>(json);
            System.Console.WriteLine(test);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
        }
    }
}