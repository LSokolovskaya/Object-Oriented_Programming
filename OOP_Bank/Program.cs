using OOP_Bank.MyClasses;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User user1 = new User(1,"test");
            // User user2 = user1;
            // System.Console.WriteLine(user1 == user2);
            // System.Console.WriteLine(user1.Equals(user2));

            Currency currency = new Currency((int)CurrencyCodes.USD,"dollar USA","$", CurrencyCodes.USD.ToString());
            System.Console.WriteLine((CurrencyCodes)currency.Code == CurrencyCodes.USD);
        }
    }
}