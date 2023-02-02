using System.Text.Json.Serialization;
public class Money
{
    public int Code { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    [JsonPropertyName("D")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public DateTime? LastUpdate { get; set; }
    [JsonIgnore]
    public string Text => $"{Code}+{Name}";
    public Money()
    {

    }

    public override string ToString()
    {
        return $"{Code}  {Name} {Symbol}";
    }
}