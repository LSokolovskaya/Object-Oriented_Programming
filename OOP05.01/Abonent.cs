namespace Abonent;
public class OutClass<TData> //YKey>
{
    private TData PropertyT;
    // private YKey PropertyK;
    public OutClass(TData propertyT)//, YKey propertyK)
    {
        if (propertyT == null) throw new ArgumentNullException(nameof(propertyT));
        // if (propertyK == null) throw new ArgumentNullException(nameof(propertyK));
        PropertyT = propertyT;
        // PropertyK = propertyK;
    }

    public void Show()
    {
        System.Console.WriteLine($"{PropertyT.ToString()}"); //{PropertyK.ToString()} ");
    }

    public TData GetPropertyT() => PropertyT;

    public void SetPropertyT(TData propertyT)
    {
        PropertyT = propertyT;
    }
}