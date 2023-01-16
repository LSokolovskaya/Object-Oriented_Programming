using MyClasses;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card("1");
            // card.TryGetMoney(100);
            // card.PushMoney(100);
            // card.TryGetMoney(100);

            // System.Console.WriteLine((int)WalletTypes.Crypto);
            // System.Console.WriteLine((int)WalletTypes.Leather);

            Wallet wallet = new Wallet(WalletTypes.Leather, 10);
            wallet.PushMoney(5);

            Shop shop = new Shop ();
            shop.Pay(wallet);
            shop.Pay(card);

            

        }
    }
}