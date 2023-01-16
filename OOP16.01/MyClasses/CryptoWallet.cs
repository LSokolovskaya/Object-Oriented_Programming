using Wallets;

namespace MyClasses;

public class CryptoWallet : Wallet
{
    public CryptoWallet(decimal money) : base(WalletTypes.Leather, money)
    {

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