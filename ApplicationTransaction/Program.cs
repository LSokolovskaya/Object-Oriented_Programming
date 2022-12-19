// See https://aka.ms/new-console-template for more information
using AppTransaction.Core;

namespace AppTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationTransaction applicationTransaction =
            new ApplicationTransaction();
            applicationTransaction.SignIn();
        }
    }
}