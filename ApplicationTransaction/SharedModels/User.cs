using System;

namespace AppTransaction.SharedModels;

public class User
{
    public int ID { get; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public User(int id)
    {
        ID = id;
    }
    public User(int id, string name, string password, string email) : this(id)
    {
        Name = name;
        Password = password;
        Email = email;
    }
    public override string ToString()
    {
        return $"{ID} {Name}";
    }
}
