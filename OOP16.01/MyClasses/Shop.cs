namespace MyClasses;

public class Shop
{
    public decimal Money { get; set; }
    public void Pay(IPayment item)
    {
        if (decimal.TryParse(Console.ReadLine(), out decimal sum))
        {
            if (item.TryGetMoney(sum))
            {
                Money += sum;
            }
            else
            {
                System.Console.WriteLine("Not enought money");
            }
        }
    }
}