using Wallet;

namespace MyClasses;

public class LeatherWallet : Wallet
{
    public LeatherWallet(decimal money) : base(WalletTypes.Leather, money)
    {

    }
}