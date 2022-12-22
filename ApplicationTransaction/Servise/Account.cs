using AppTransaction.SharedModels;

namespace AppTransaction.Service;

public class Account
{
    public bool Login(User[] users, out User user)
    {
        System.Console.WriteLine("Enter email");
        string? email = Console.ReadLine();
        System.Console.WriteLine("Enter pass");
        string? pass = Console.ReadLine();
        user = Search(users, email, pass);
        return user != null;
    }
    private User Search(User[] users, string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("Error input");
            return null;
        }
        foreach (User user in users)
        {
            if (user.Email == email && user.Password == pass)
            {
                System.Console.WriteLine("Successful login");
                return user;
            }
        }
        System.Console.WriteLine("Error input");
        return null;
    }
}