// +Реализуйте класс ServerPost. Обязательными методами считаются методы Middleware, Controller, Service, Repository.
// Цепочка взаимодействия между методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// +Middleware – метод валидатор
// +Controller – метод, принимающий данные. Принимает данные клиента
// +Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. 
// Взаимодействие с этим массивом осуществляется только в Repository. 
// Массив находится в приложении
// Задание:
// на вход подается параметры name, age
// Необходимо добавить в массив БД объект только в том случае, если нет совпадений по name. 
// Если совпадения нет, то в объект клиента добавить ключ Id с последним возможным уникальным Id БД, 
// таким образом, чтобы в БД был запушен объект вида {“Id": 6, Name : "Test", Age : 1}
// Если совпадение есть – ошибка. Добавить проверки

using UserOBD;

namespace Post;

public class ServerPost
{
    private User[] user;
    private readonly User[] _user;

    public ServerPost()
    {
        user = new User[50];

        user[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        user[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        user[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        user[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
    }


    public User Controller(int age, string name)
    {
        if (Middleware(age, name))
        {
            return Service(age, name);
        }
        else
        {
            Console.WriteLine("Error");
            return null;
        }
    }

    public bool Middleware(int age, string name)
    {
        return age > 0 && age < 123 &&
        !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(Convert.ToString(age));
    }

    public User Service(int age, string name)
    {
        User user = Repository(age, name);
        if (user == null)
        {
            Console.WriteLine("Not found data");
        }
        return user;
    }

    public User Repository(int age, string name)
    {
        foreach (User user in _user)
        {
            if (user.Name == name)
            {
                System.Console.WriteLine("Этот пользователь уже существует"); 
            }
            else
            {
                user = new User() { Id= 6, Name = "Test", Age = age};
            }
        }
        return null;
    }
}