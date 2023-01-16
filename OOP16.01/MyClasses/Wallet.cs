namespace MyClasses;

public class Wallet : IPayment
{
    public decimal Money { get; private set; }
    public readonly WalletTypes Type;
    public Wallet(WalletTypes type, decimal money = 0)
    {
        Money = money;
        Type = type;
    }

    public void PushMoney(decimal money)
    {
        Money += money;
        System.Console.WriteLine($"You put on account {Money}");
    }

    public bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            System.Console.WriteLine($"You pay {sum}");
            return true;
        }
        return false;
    }
}