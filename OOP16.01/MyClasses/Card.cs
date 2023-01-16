namespace MyClasses;

public class Card : IPayment
{
    public decimal Money { get; private set; }
    public string Number { get; private set; }

    public Card(string number, decimal money = 0)
    {
        Number = number;
        Money = money;
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