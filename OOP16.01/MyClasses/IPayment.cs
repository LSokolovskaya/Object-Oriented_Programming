namespace MyClasses;

public interface IPayment
{
    decimal Money { get; }
    void PushMoney(decimal money);
    bool TryGetMoney(decimal sum);
}