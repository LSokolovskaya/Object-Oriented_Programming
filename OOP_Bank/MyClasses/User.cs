namespace OOP_Bank.MyClasses;

public class User
{
    public int Id { get; }
    public string Name { get; set; } = "no name";

    public User(int id)
    {
        Id = id;
    }

    public User(int Id, string name) : this(Id)
    {
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not User)
        {
            return false;
        }
        if(this == obj)
        {
            System.Console.WriteLine("link is equals");
            return true;
        }
        User user = (User) obj;
        return this.Id == user.Id && this.Name == user.Name;
    }

    public override int GetHashCode()
    {
        return Id * 1000 ;
    }
}